using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating
{
    public class AutoPolicyRater
    {
        private ConsoleLogger _logger;
        private RatingEngine _ratingEngine;

        public AutoPolicyRater(ConsoleLogger logger,RatingEngine engine)
        {
            _logger = logger;
            _ratingEngine = engine;
        }

        public void Rate(Policy policy)
        {
            _logger.Log("Rating AUTO policy...");
            _logger.Log("Validating policy.");
            if (String.IsNullOrEmpty(policy.Make))
            {
                _logger.Log("Auto policy must specify Make");
                return;
            }
            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    _ratingEngine.Rating = 1000m;
                }
                    _ratingEngine.Rating = 900m;
            }
        }
    }
}
