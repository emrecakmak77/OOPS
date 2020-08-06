using OOPS.BLL.Abstract;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.ProjectBase;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.ProjectBaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS.BLL.Concreate
{
    public class ImageService : IImageService
    {
        private readonly IUnitofWork uow;
        public ImageService(IUnitofWork _uow)
        {
            uow = _uow;
        }

        public List<ImageDTO> getAll()
        {
            var getImageList = uow.GetRepository<Image>().GetAll().ToList();
            return MapperFactory.CurrentMapper.Map<List<ImageDTO>>(getImageList);
        }

        public List<ImageDTO> getUserImages(int ImageId)
        {
            throw new NotImplementedException();
        }

        public ImageDTO newImage(int ImageId)
        {
            throw new NotImplementedException();
        }

        public ImageDTO updateImage(ImageDTO image)
        {
            throw new NotImplementedException();
        }
    }
}
