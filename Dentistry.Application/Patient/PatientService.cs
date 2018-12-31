using AutoMapper;
using Dentistry.Application.Patient.Dto;
using Dentistry.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dentistry.Application.Patient
{
    public  class PatientService : IPatientService
    {
        private readonly IRepository<Core.Patient.Patient> _patientRepository;
        private readonly IMapper _mapper;

        public PatientService(IRepository<Core.Patient.Patient> patientRepository)
        {

        }
        //public PatientService(IMapper mapper)
        //{

        //}
        //public PatientService(IRepository<Core.Patient.Patient> patientRepository, IMapper mapper)
        //public PatientService( IMapper mapper)
        //{
        //   // _patientRepository = patientRepository;
        //    _mapper = mapper;
        //}

        public void GetAll()
        {

        }
        //public IEnumerable<UserListDto> GetAll()
        //{
        //    var patients = _patientRepository.GetAll();
        //    return null;
        //}

        //public CustomerViewModel GetById(Guid id)
        //{
        //    return _mapper.Map<CustomerViewModel>(_customerRepository.GetById(id));
        //}

        //public async Task<IPagedList<UserListDto>> GetDentistAsync(PatientListInput input)
        //{
        //    var query = _patientRepository.GetAll(
        //            !input.Filter.IsNullOrEmpty(),
        //            predicate => predicate.Name.Contains(input.Filter) || predicate.Email.Contains(input.Filter));

        //    var usersCount = await query.CountAsync();
        //    var users = query.PagedBy(input.PageIndex, input.PageSize).ToList();
        //    //var userListDtos = _mapper.Map<List<UserListDto>>(users);

        //    return null;// userListDtos.ToPagedList(usersCount);
        //}
    }
}
