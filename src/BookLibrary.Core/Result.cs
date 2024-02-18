namespace BookLibrary.Core
{
    public class Result
    {
        protected Result(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }

        protected Result(bool isSuccess, string error) : this(isSuccess)
        {
            _errors.Add(error);
        }

        protected Result(bool isSuccess, IEnumerable<string> errors) : this(isSuccess)
        {
            if (isSuccess && errors.Any() ||
                !isSuccess && !errors.Any())
            {
                throw new InvalidOperationException();
            }

            _errors.AddRange(errors);
        }

        public bool IsSuccess { get; }

        private readonly List<string> _errors = new();
        public IReadOnlyList<string> Errors => _errors.AsReadOnly();

        public static Result Success() => new(true);
        public static Result WithError(string error) => new(false, error);
        public static Result WithErrors(IEnumerable<string> errors) => new(false, errors.ToArray());
    }

    public class Result<TValue> : Result
    {
        protected internal Result(TValue? value, bool isSuccess)
        : base(isSuccess)
        {
            Value = value;
        }

        protected internal Result(TValue? value, bool isSuccess, string error)
            : base(isSuccess, error)
        {
            Value = value;
        }

        protected internal Result(TValue? value, bool isSuccess, IEnumerable<string> errors)
            : base(isSuccess, errors)
        {
            Value = value;
        }

        public readonly TValue? Value;

        public static Result<TValue> Success(TValue? value) => new(value, true);
        public static Result<TValue> WithError(string error) => new(default, false, error);
        public static Result<TValue> WithErrors(IEnumerable<string> errors) => new(default, false, errors);
    }
}
