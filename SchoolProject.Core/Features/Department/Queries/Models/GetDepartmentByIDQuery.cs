﻿using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Department.Queries.Results;

namespace SchoolProject.Core.Features.Department.Queries.Models
{
    public class GetDepartmentByIDQuery : IRequest<Response<GetDepartmentByIDResponse>>
    {
        public int Id { get; set; }
        public GetDepartmentByIDQuery(int id)
        {
            Id = id;
        }
    }
}
