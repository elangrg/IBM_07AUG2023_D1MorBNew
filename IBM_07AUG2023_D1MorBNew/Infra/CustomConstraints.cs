using System.Globalization;
using System.Text.RegularExpressions;

namespace IBM_07AUG2023_D1MorBNew.Infra
{

    public class NotEqual : IRouteConstraint
    {
        private string _value;

        public NotEqual(string value)
        {
            _value = value;
        }

        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)

        {


            var paramValue = values[routeKey].ToString();
            return String.Compare(paramValue, _value, true) != 0;
        }

    }





    public class AlphaNumericConstraint : IRouteConstraint
    {
        private static readonly TimeSpan RegexMatchTimeout = TimeSpan.FromSeconds(10);

        public bool Match(HttpContext httpContext,
            IRouter route,
            string routeKey,
            RouteValueDictionary values,
            RouteDirection routeDirection)
        {
            //validate input params  
            if (httpContext == null)
                throw new ArgumentNullException(nameof(httpContext));

            if (route == null)
                throw new ArgumentNullException(nameof(route));

            if (routeKey == null)
                throw new ArgumentNullException(nameof(routeKey));

            if (values == null)
                throw new ArgumentNullException(nameof(values));

            object routeValue;

            if (values.TryGetValue(routeKey, out routeValue))
            {
                var parameterValueString = Convert.ToString(routeValue, CultureInfo.InvariantCulture);
                return new Regex(@"^[a-zA-Z0-9]*$",
                                RegexOptions.CultureInvariant
                                | RegexOptions.IgnoreCase, RegexMatchTimeout).IsMatch(parameterValueString);
            }

            return false;
        }
    }




}
