﻿using BAYSOFT.Abstractions.Pages;
using Microsoft.Extensions.Logging;

namespace BAYSOFT.Pages
{
    public class IndexModel : PageModelBase
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
