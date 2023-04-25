using AutoMapper;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.AspNetCore.Mvc;
using SFCredito.Dominio.Entidades;
using SFCredito.Dominio.Services.Interfaces;
using SFCredito.Web.Models;
using System.Diagnostics;
using static Google.Apis.Drive.v3.DriveService;
using System.Collections;

namespace SFCredito.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPerfilServices _perfilServices;
        private readonly IDigitacaoServices _documentolServices;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IPerfilServices perfilServices, IDigitacaoServices _documentolServices, IMapper mapper)
        {
            _mapper = mapper;
            _logger = logger;
            _perfilServices = perfilServices;
        }

        public IActionResult Index()
        {

            var perfil = _mapper.Map<PerfiilModel, Perfil>(new PerfiilModel { Nome = "Lucas" });

            var teste = _perfilServices.Adcionar(perfil);

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UploadToFileSystem(List<IFormFile> files, string description)
        {
            foreach (var file in files)
            {
                var basePath = Path.Combine(Directory.GetCurrentDirectory() + "\\Files\\");
                bool basePathExists = System.IO.Directory.Exists(basePath);
                if (!basePathExists) Directory.CreateDirectory(basePath);
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                var filePath = Path.Combine(basePath, file.FileName);
                var extension = Path.GetExtension(file.FileName);
                string folder = "Jose";
                if (file.Length > 0)
                {
                    using (var ms = new MemoryStream())
                    {
                        file.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        string s = Convert.ToBase64String(fileBytes);

                        MemoryStream stream = new MemoryStream(fileBytes);

                        UploadFile(stream, fileName, file.ContentType, folder, description);

                        // act on the Base64 data
                    }
                }
            }
            TempData["Message"] = "File successfully uploaded to File System.";
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public static string CreateFolder(DriveService service, string folderName)
        {
            var newFile = new Google.Apis.Drive.v3.Data.File { Name = folderName, MimeType = "application/vnd.google-apps.folder" };

            // Define parameters of request.
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 10;
            listRequest.Fields = "nextPageToken, files(id, name)";

            // List files.
            IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute()
                .Files;

            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    if (file.Name == newFile.Name)
                    {
                        Console.WriteLine("File already existing... Skip creation");
                        return file.Id;
                    }
                }
            }
            else
            {
                Console.WriteLine("No files found.");
            }
            Console.WriteLine("Creating new file...");

            var result = service.Files.Create(newFile).Execute();

            return result.Id;
        }

        public string CreateFolder(string folderName, string? parent = null )
        {
            var service = GetService();
            var driveFolder = new Google.Apis.Drive.v3.Data.File();
            driveFolder.Name = folderName;
            driveFolder.MimeType = "application/vnd.google-apps.folder";
            driveFolder.Parents = new string[] { parent };
            var command = service.Files.Create(driveFolder);
            var file = command.Execute();
            return file.Id;
        }
        public void DeleteFile(string fileId)
        {
            var service = GetService();
            var command = service.Files.Delete(fileId);
            var result = command.Execute();
        }

        public IEnumerable<Google.Apis.Drive.v3.Data.File> GetFiles(string folder)
        {
            var service = GetService();

            var fileList = service.Files.List();
            fileList.Q = $"mimeType!='application/vnd.google-apps.folder' and '{folder}' in parents";
            fileList.Fields = "nextPageToken, files(id, name, size, mimeType)";

            var result = new List<Google.Apis.Drive.v3.Data.File>();
            string pageToken = null;
            do
            {
                fileList.PageToken = pageToken;
                var filesResult = fileList.Execute();
                var files = filesResult.Files;
                pageToken = filesResult.NextPageToken;
                result.AddRange(files);
            } while (pageToken != null);


            return result;
        }

        public string UploadFile(Stream file, string fileName, string fileMime, string folder, string fileDescription)
        {


            //CreateFolder("Aqui");

            DriveService service = GetService();

          var id=  CreateFolder(service,folder);


            var driveFile = new Google.Apis.Drive.v3.Data.File();
            driveFile.Name = fileName;
            driveFile.Description = fileDescription;
            driveFile.MimeType = fileMime;
            driveFile.Parents = new string[] { id };


            var request = service.Files.Create(driveFile, file, fileMime);
            request.Fields = "id";

            var response = request.Upload();
            if (response.Status != Google.Apis.Upload.UploadStatus.Completed)
                throw response.Exception;

            return request.ResponseBody.Id;
        }

        private DriveService GetService()
        {
            var tokenResponse = new TokenResponse
            {
                AccessToken = "ya29.a0AVvZVsqw0wu0OAFm1wUKXXWCFpJHgVMFWKj4ZUl1U66LpYwZUySdgq8W_Dkc9XmXxiVz-r7sV6gR7A-J9tKE9Zr-aRCxza5eXuafc0pb0GwX0nyqaFGlXOMfT1d5MnFIpMCcx4e4g5p9g0ekSp6FZ5rxJzyraCgYKAZYSARISFQGbdwaIZPgwCltIQvaej5SKZxJttQ0163",
                RefreshToken = "1//04Cj5NylnxfhKCgYIARAAGAQSNwF-L9Ir1RgXqH5wS8GyhPvx6CMAX4xZ3F0_lhFUjounSkTRr4Dqz7gUUuW9l9T7Lnnv61lYdwA",
             
            };


            var applicationName = "sfcredito"; // Use the name of the project in Google Cloud
            var username = "lucasbsilrs@gmail.com"; // Use your email


            var apiCodeFlow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
            {
                ClientSecrets = new ClientSecrets
                {
                    ClientId = "872358829857-akobga9ob5nephjcs2birqkp95i751im.apps.googleusercontent.com",
                    ClientSecret = "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"
                },
                Scopes = new[] { Scope.Drive },
                DataStore = new FileDataStore(applicationName)
            });


            var credential = new UserCredential(apiCodeFlow, username, tokenResponse);


            var service = new DriveService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = applicationName
            });
            return service;
        }


        [HttpPost]
        public async Task<IActionResult> CheckOut(UsuarioModel checkOut)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("Privacy", checkOut);
            }
            return Json(new { success = true });
        }
    }
}