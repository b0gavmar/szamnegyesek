using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szamnegyes.Shared.Models;

namespace Szamnegyes.Shared.Converters
{
    public static class FoursConverter
    {
        public static Fours ToModel(this FoursDto dto)
        {
            if (dto.list.Count() == 4)
            {
                return new Fours
                {
                    A = dto.list[0],
                    B = dto.list[1],
                    C = dto.list[2],
                    D = dto.list[3],
                    Id = Convert.ToInt32(dto.list[0].ToString()+ dto.list[1].ToString() + dto.list[2].ToString() + dto.list[3].ToString()),
                };
            }
            else
            {
                throw new InvalidDataException("Invalid data");
            }
            
        }
    }
}
