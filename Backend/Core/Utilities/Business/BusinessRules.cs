using Core.Utilities.Results;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach (var Rules in logics)
            {
                if (!Rules.Success)
                {
                    return Rules;
                }
            }
            return null;
        }
    }
}
