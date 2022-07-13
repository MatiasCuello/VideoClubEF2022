using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Datos.Repositorios.Facades;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Datos.Repositorios
{
    public class RepositorioLocalidades:IRepositorioLocalidades
    {
        private readonly VideoClubEF2022DbContext context;

        public RepositorioLocalidades()
        {
            context = new VideoClubEF2022DbContext();
        }
        
        public void Guardar(Localidad localidad)
        {
            try
            {
                //if (localidad.Provincia != null)
                //{
                //    context.Provincias.Attach(localidad.Provincia);
                //}
                if (localidad.LocalidadId == 0)
                {
                    context.Localidades.Add(localidad);
                }
                else
                {
                    var localidadEnDB = context.Localidades
                        .SingleOrDefault(l => l.LocalidadId == localidad.LocalidadId);
                    if (localidadEnDB == null)
                    {
                        throw new Exception("Código de localidad inexistente...");
                    }

                    localidadEnDB.NombreLocalidad = localidad.NombreLocalidad;
                    localidadEnDB.ProvinciaId = localidad.ProvinciaId;
                    context.Entry(localidadEnDB).State = EntityState.Modified;

                }

                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Localidad localidad)
        {
            try
            {
                if (localidad.LocalidadId == 0)
                {
                    return context.Localidades
                        .Any(l => l.NombreLocalidad == localidad.NombreLocalidad);
                }
                return context.Localidades.Any(l => l.NombreLocalidad == localidad.NombreLocalidad &&
                                                    l.Provincia==localidad.Provincia /*&&*/
                                                /*   l.LocalidadId != localidad.LocalidadId*/);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int localidadId)
        {
            try
            {
                var localidadEnDB = context.Localidades
                    .SingleOrDefault(l => l.LocalidadId == localidadId);
                if (localidadEnDB == null)
                {
                    throw new Exception("Localidad no encontrada");
                }
                context.Entry(localidadEnDB).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Localidad localidad)
        {
            try
            {
                return 
                    context.Socios
                    .Any(s => s.LocalidadId == localidad.LocalidadId) &&
                    context.Empleados
                        .Any(e => e.LocalidadId == localidad.LocalidadId) &&
                    context.Proveedores
                        .Any(p=>p.LocalidadId==localidad.LocalidadId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Localidad GetLocalidadPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Localidad> GetLista(Provincia provincia)
        {
            try
            {
                return context.Localidades
                    .Include(l => l.Provincia)
                    .ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

