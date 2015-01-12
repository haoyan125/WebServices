using System;
using HY.MiPlate.Services.Contact;

namespace HY.MiPlate.Services.Domain
{
    public class SampleDomain : ISampleDomain
    {
        public ResultBase<SampleDto> GetSampleData(int id)
        {
            return new ResultBase<SampleDto>()
            {
                IsSuccessful = true,
                Data = new SampleDto()
                {
                    Id = 1,
                    Name = "aa"
                }
            }; 
        }
    }
}