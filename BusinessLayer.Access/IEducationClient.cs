using BusinessLayer.Dto;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Client
{
    internal interface IEducationClient
    {
        // This interface wrote for nuGet packages but not used now
        [Get("/get-education")]
        Task<ApiResponse<EducationDto>> GetEducation(int educationId);

        [Get("/get-educations")]
        Task<ApiResponse<List<EducationDto>>> GetEducations();

        [Get("/get-sub-educations-by-education-id")]
        Task<ApiResponse<List<EducationDto>>> GetSubEducations(int educationId);

        [Post("/add-education")]
        Task<ApiResponse<BaseResponse>> AddEducation([Body] EducationDto request);

        [Delete("/delete-education")]
        Task<ApiResponse<BaseResponse>> DeleteEducation(int educationId);
    }
}
