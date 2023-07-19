using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipUygulamasi.Entities.Abstract
{	
	public interface IBaseEntity
	{		//Her çalışanın zorunlu olması gereken Id
			int Id { get; set; }
    }
}
