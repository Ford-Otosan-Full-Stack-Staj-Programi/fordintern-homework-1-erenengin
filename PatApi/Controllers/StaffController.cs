using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatApi.Data;
using System;


namespace PatApi.Controllers
{
    [Route("patika/api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public StaffController(IUnitOfWork unitOfWork) { 
        this.unitOfWork = unitOfWork;
        }


        [HttpGet]
        public List<Staff>GetAll() { 
        
         List<Staff> staff = unitOfWork.StaffRepository.GetAll();

            return staff;
        }

        [HttpPost]
        public void Post([FromBody] Staff request)
        {
            unitOfWork.StaffRepository.Insert(request);
            unitOfWork.Complete();
        }

       
            [HttpGet("{id}")]
            public Staff GetById(int id)
            {
                Staff Staff = unitOfWork.StaffRepository.GetById(id);
                return Staff;
            }

        [HttpPut("{id}")]
        public void Put([FromRoute]int id, [FromBody] Staff request)
        {
            request.Id = id;
            unitOfWork.StaffRepository.Update(request);
            unitOfWork.Complete();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            unitOfWork.StaffRepository.Delete(id);
            unitOfWork.Complete();
        }
        [HttpGet("GetByFilter")]
        public List<Staff> GetByCityAndLastName([FromQuery]string city, string lastName)
        {
            List<Staff> list = unitOfWork.StaffRepository.GetAll();
            var filteredEntity = list.Where(x => x.City.Equals(city) && x.LastName.Equals(lastName));
            return filteredEntity.ToList();
        }


        


    }
}
