﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckApp
{
    class MultiLevelGarages
    {
        /// <summary>
        /// Список с уровнями парковки
        /// </summary>
        List<Garages<ITransport>> parkingStages;
        /// <summary>
        /// Сколько мест на каждом уровне
        /// </summary>

        private const int countPlaces = 20;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="countStages">Количество уровенй парковки</param>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public MultiLevelGarages(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Garages<ITransport>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Garages<ITransport>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Garages<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
    }
}
