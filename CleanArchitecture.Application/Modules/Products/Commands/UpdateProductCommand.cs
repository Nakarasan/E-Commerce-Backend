﻿using CleanArchitecture.Application.Modules.Products.Extensions;
using CleanArchitecture.Application.Modules.Products.Services;
using MediatR;
using Shared.Common.Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Modules.Products.Commands
{
    public class UpdateProductCommand : IRequest<ResponseResult<bool>>
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public bool IsEnable { get; set; }
        public string? Tags { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int BrandId { get; set; }
        public int WarrantyId { get; set; }
        public int ManufacturerId { get; set; }
    }

    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, ResponseResult<bool>>
    {
        private readonly IProductService productService;

        public UpdateProductCommandHandler(IProductService productService)
        {
            this.productService = productService;
        }
        public async Task<ResponseResult<bool>> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
        {
            var request = command.ToServiceRequest();
            return await productService.UpdateProductAsync(command.Id, request);
        }
    }
}
