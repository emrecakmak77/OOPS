using OOPS.BLL.Abstract.StaticAbstract;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.Static;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.EmployeeModel;
using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS.BLL.Concreate.StaticConcreate
{
    public class VisaDocumentRequestsService : IVisaDocumentRequestsService
    {
        private readonly IUnitofWork uow;
        public VisaDocumentRequestsService(IUnitofWork uow)
        {
            this.uow = uow;
        }

        public List<VisaDocumentRequestDTO> getAllEmployeeVisaDocumentRequests()
        {
            var emp = uow.GetRepository<VisaDocumentRequests>().Get(null, x => x.VisaType).OrderByDescending(x=>x.Id).ToList();
            return MapperFactory.CurrentMapper.Map<List<VisaDocumentRequestDTO>>(emp);
        }

        public List<VisaDocumentRequestDTO> getEmployeeVisaDocumentRequests(int employeeId)
        {
            var emp = uow.GetRepository<EmployeeVisa>().GetAll().Where(x => x.EmployeeId == employeeId).Select(x => x.VisaDocumentRequests).ToList();
            return MapperFactory.CurrentMapper.Map<List<VisaDocumentRequestDTO>>(emp);
        }

        public VisaDocumentRequestDTO getVisaDocumentRequest(int Id)
        {
            var getVisaDocumentRequest = uow.GetRepository<VisaDocumentRequests>().GetAll().Where(x => x.Id == Id).FirstOrDefault();
            return MapperFactory.CurrentMapper.Map<VisaDocumentRequestDTO>(getVisaDocumentRequest);
        }

        public VisaDocumentRequestDTO newVisaDocumentRequest(VisaDocumentRequestDTO VisaDocumentRequest)
        {
            var addedVisaDocumentRequest = MapperFactory.CurrentMapper.Map<VisaDocumentRequests>(VisaDocumentRequest);
            uow.GetRepository<VisaDocumentRequests>().Add(addedVisaDocumentRequest);
            uow.SaveChanges();
            var addedEmployeeVisaDocumentRequest = new EmployeeVisa()
            {
                EmployeeId = VisaDocumentRequest.EmployeeId,
                VisaDocumentRequestsId = addedVisaDocumentRequest.Id
            };
            uow.GetRepository<EmployeeVisa>().Add(addedEmployeeVisaDocumentRequest);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<VisaDocumentRequestDTO>(addedVisaDocumentRequest);
        }

        public VisaDocumentRequestDTO updateVisaDocumentRequest(VisaDocumentRequestDTO VisaDocumentRequest)
        {
            var selectedEmp = uow.GetRepository<EmployeeVisa>().Get(x => x.Id == VisaDocumentRequest.Id);
            selectedEmp = MapperFactory.CurrentMapper.Map(VisaDocumentRequest, selectedEmp);
            uow.GetRepository<EmployeeVisa>().Update(selectedEmp);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<VisaDocumentRequestDTO>(selectedEmp);
        }
    }
}
