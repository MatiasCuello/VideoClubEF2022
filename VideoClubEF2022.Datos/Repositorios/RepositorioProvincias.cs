using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using VideoClubEF2022.Datos.Repositorios.Facades;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Datos.Repositorios
{
    public class RepositorioProvincias : IRepositorioProvincias
    {
        private readonly VideoClubEF2022DbContext context;

        public RepositorioProvincias()
        {
            context = new VideoClubEF2022DbContext();
        }

        public RepositorioProvincias(VideoClubEF2022DbContext context)
        {
            this.context = context;
        }

        public void Borrar(int provinciaId)
        {
            try
            {
                var provinciaEnDB = context.Provincias
                    .SingleOrDefault(p => p.ProvinciaId == provinciaId);
                if (provinciaEnDB == null)
                {
                    throw new Exception("Provincia no encontrada");
                }
                context.Entry(provinciaEnDB).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Provincia provincia)
        {
            try
            {
                return context.Localidades
                    .Any(l => l.ProvinciaId == provincia.ProvinciaId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Provincia GetProvinciaPorId(int id)
        {
            try
            {
                return context.Provincias.SingleOrDefault(p => p.ProvinciaId == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public bool Existe(Provincia provincia)
        {
            try
            {
                if (provincia.ProvinciaId == 0)
                {
                    return context.Provincias
                        .Any(p => p.NombreProvincia == provincia.NombreProvincia);
                }
                return context.Provincias.Any(p => p.NombreProvincia == provincia.NombreProvincia &&
                                                   p.ProvinciaId != provincia.ProvinciaId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Provincia> GetLista()
        {
            try
            {
                return context.Provincias.AsNoTracking().ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(Provincia provincia)
        {
            try
            {
                if (provincia.ProvinciaId == 0)
                {
                    context.Provincias.Add(provincia);

                }
                else
                {
                    var provinciaEnDB = context.Provincias
                        .SingleOrDefault(p => p.ProvinciaId == provincia.ProvinciaId);
                    if (provinciaEnDB == null)
                    {
                        throw new Exception("Provincia no encontrada");
                    }

                    provinciaEnDB.NombreProvincia = provincia.NombreProvincia;
                    context.Entry(provinciaEnDB).State = EntityState.Modified;
                    context.SaveChanges();
                }
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
