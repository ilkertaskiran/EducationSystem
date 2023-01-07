using BusinessLayer.Dto;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Client
{
    public interface ISubEducationProgramClient
    {
        [Get("/get-sub-education")]
        Task<ApiResponse<SubEducationDto>> GetSubEducation(int subEducationId);

        [Get("/get-education-by-sub-education-id")]
        Task<ApiResponse<EducationDto>> GetEducationBySubEducationId(int subEducationId);

        [Get("/get-sub-educations")]
        Task<ApiResponse<List<SubEducationDto>>> GetSubEducations(int educationId);

        [Post("/add-sub-education")]
        Task<ApiResponse<BaseResponse>> AddSubEducation([Body]SubEducationDto request);

        [Delete("/delete-sub-education")]
        Task<ApiResponse<BaseResponse>> DeleteSubEducation(int subEducationId);

    }
}
