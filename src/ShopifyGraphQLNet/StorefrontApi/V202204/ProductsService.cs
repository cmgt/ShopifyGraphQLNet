﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using ShopifyGraphQLNet.Types;

namespace ShopifyGraphQLNet.StorefrontApi.V202204
{
    public class ProductsService
    {
        private readonly ShopifyGraphQLNetClient client;
        private readonly ILogger<ProductsService> logger;

        public ProductsService(ShopifyGraphQLNetClient client, ILogger<ProductsService> logger)
        {
            this.client = client;
            this.logger = logger;
        }

        public async Task<T> ListProducts<T>(T value, ProductConnectionArguments? arguments = default,
            CancellationToken cancellationToken = default)
        {

        }
    }
}
