using OOPS.Core.Business;
using OOPS.DTO.ProjectBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract
{
    public interface IImageService : IServiceBase
    {
        ImageDTO newImage(int ImageId);
        List<ImageDTO> getAll();
        List<ImageDTO> getUserImages(int ImageId);
        ImageDTO updateImage(ImageDTO image);
    }
}
