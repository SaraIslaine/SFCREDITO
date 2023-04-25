using FluentValidation.Results;

namespace SFCredito.Shared.Exceptions
{
    public class SFCreditoException : Exception
    {
        public int Code { get; set; }

        public SFCreditoException(string message)
            : base(message)
        {

        }

        public SFCreditoException(int code, string message)
            : base(message)
        {
            this.Code = code;
        }

        public SFCreditoException(int code, string message, params object[] arg)
            : base(string.Format(message, arg))
        {
            this.Code = code;
        }

        public SFCreditoException()
         : base("Um ou mais falhas de validação ocorreram.")
        {
            Failures = new Dictionary<string, string[]>();
        }

        public SFCreditoException(List<ValidationFailure> failures)
            : this()
        {
            var propertyNames = failures
                .Select(e => e.PropertyName)
                .Distinct();

            foreach (var propertyName in propertyNames)
            {
                var propertyFailures = failures
                    .Where(e => e.PropertyName == propertyName)
                    .Select(e => e.ErrorMessage)
                    .ToArray();

                Failures.Add(propertyName, propertyFailures);
            }
        }

        public IDictionary<string, string[]> Failures { get; }
    }
}
