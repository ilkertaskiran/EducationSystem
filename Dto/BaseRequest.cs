﻿using MediatR;

namespace BusinessLayer.Dto
{
    public class BaseRequest : IRequest<BaseResponse>
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime? UpdatedTime { get; set; } = DateTime.Now;
    }
}
