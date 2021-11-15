using System.Collections.Generic;
using VegunSoft.Customer.Entity.Provider.Image;

namespace VegunSoft.Layer.UcControl.Customer.Forms
{
    public interface IFormImage
    {
        void Start(MEntityCustomerImageFolder model, List<MEntityCustomerImage> images);
    }
}
