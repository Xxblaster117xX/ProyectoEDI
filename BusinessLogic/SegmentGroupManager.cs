using Entities.Entidades_Definicion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SegmentGroupManager
    {
        /// <summary>
        /// La clase se encarga de manejejar el segmento y su propiedades.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="segment"></param>
        /// <exception cref="ArgumentNullException"></exception>
        private readonly List<SegmentGroup> _segmentsGroups;
        /// <summary>
        /// Constructor de la clase SegmentManager.
        /// </summary>
        /// 

        private int contador = 0;

        public int AutoIncrement()
        {
            return ++contador;
        }

        public SegmentGroupManager()
        {
            _segmentsGroups = new List<SegmentGroup>();
        }
        /// <summary>
        /// Este método agrega un segmento a la lista de segmentos.
        /// </summary>
        /// <param name="segment"></param>
        public void AddSegmentGroup(SegmentGroup SegmentGroup)
        {
            _segmentsGroups.Add(SegmentGroup);
        }
        
        
        /// <summary>
        /// Devulve la lista de segmentos
        /// </summary>
        /// <returns></returns>
        public List<SegmentGroup> GetAllSegmentsGroups()
        {
            return _segmentsGroups;
        }

        /// <summary>
        /// Este método obtiene un grupo de segmento por id .
        /// </summary>
        ///
        public SegmentGroup GetSegmentGroupById(int id)
        {
            return _segmentsGroups.FirstOrDefault(gs => gs.Id == id);
        }

        /// <summary>
        /// Emétodo para actualizar un segment group
        /// </summary>
        ///

        public void UpdateComposite(SegmentGroup GrupoSegmento)
        {
            // obtebemos el grupo de segmento existente por id
            var existingElement = GetSegmentGroupById(GrupoSegmento.Id);
            if (existingElement != null)
            {
                // actualizamos las propiedades del grupo de segmento existente
                existingElement.NumeroGrupoSegmentos = GrupoSegmento.NumeroGrupoSegmentos;
                existingElement.Obligatorio = GrupoSegmento.Obligatorio;
                existingElement.Segments = GrupoSegmento.Segments;
                existingElement.SegmentsGroups = GrupoSegmento.SegmentsGroups;
            }
            

        }


    }
}
