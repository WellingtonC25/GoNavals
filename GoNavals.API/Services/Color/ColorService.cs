﻿using GoNavals.Domain;
using Microsoft.EntityFrameworkCore;

namespace GoNavals.API.Services.Color
{
    public class ColorService : IColorService
    {
        private readonly DataContext _dataContext;
        List<Domain.Color> _colores = new List<Domain.Color>();

        public ColorService(Domain.DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<Domain.Color>?> DeleteColor(int id)
        {
            var result = await _dataContext.Color.FindAsync(id);

            if (result is null)
            {
                return null;
            }

             _dataContext.Remove(result);
             await _dataContext.SaveChangesAsync();

            return _colores;
        }

        public async Task<IEnumerable<Domain.Color>?> GetAllColores()
        {
            if (_dataContext.Color == null)
            {
                return null;
            }
            return await _dataContext.Color.ToListAsync();
        }

        public async Task<Domain.Color?> GetSingleColor(int id)
        {
            if (_dataContext.Color == null)
            {
                return null;
            }
            var color = await _dataContext.Color.FindAsync(id);

            if (color == null)
            {
                return null;
            }

            return color;
        }

        public async Task<IEnumerable<Domain.Color>?> AddColor(Domain.Color color)
        {
            var result = await _dataContext.AddAsync(color);

            await _dataContext.SaveChangesAsync();

            return _colores;
        }

        public async Task<IEnumerable<Domain.Color>?> UpdateColor(int id, Domain.Color color)
        {
            var result = await _dataContext.Color.FindAsync(id);

            if (result is null)
            {
                return null;
            }

            result.Descripcion = color.Descripcion;

            await _dataContext.SaveChangesAsync();

            return _colores;
        }
    }
}
