using System.Collections.Generic;
using VegunSoft.Order.Entity.Business.EntityLabo;

namespace VegunSoft.Layer.Gui.Forms
{
    public interface IFLabo
    {
        void Init(List<IResultOrderItemStepLabo> labo, bool v);
    }
}
