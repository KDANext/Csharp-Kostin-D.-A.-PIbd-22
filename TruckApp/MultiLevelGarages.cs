using System;
using System.Collections.Generic;
using System.IO;
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
        List<Garages<ITransport>> garagesStages;
        /// <summary>
        /// Сколько мест на каждом уровне
        /// </summary>
        /// 
        private int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int pictureHeight;

        private const int countPlaces = 20;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="countStages">Количество уровенй парковки</param>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public MultiLevelGarages(int countStages, int pictureWidth, int pictureHeight)
        {
            garagesStages = new List<Garages<ITransport>>();
            for (int i = 0; i < countStages; ++i)
            {
                garagesStages.Add(new Garages<ITransport>(countPlaces, pictureWidth,
               pictureHeight));
            }
            this.pictureHeight = pictureHeight;
            this.pictureWidth = pictureWidth;
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
                if (ind > -1 && ind < garagesStages.Count)
                {
                    return garagesStages[ind];
                }
                return null;
            }
        }
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                //Записываем количество уровней
                sw.WriteLine("CountLeveles:" + garagesStages.Count);
                foreach (var level in garagesStages)
                {
                    //Начинаем уровень
                    sw.WriteLine("Level");
                    int index = 0;
                    

                    for (int i = 0; i < countPlaces; i++)
                    {
                        var transport = level[i];
                        if (transport != null)
                        {
                            //если место не пустое
                            //Записываем тип мшаины
                            if (transport.GetType().Name == "Truck")
                            {
                                sw.Write(i + ":Truck:");
                            }
                            if (transport.GetType().Name == "FuelTruck")
                            {
                                sw.Write(i + ":FuelTruck:");
                            }
                            //Записываемые параметры
                            sw.WriteLine(transport);
                        }
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Метод записи информации в файл
        /// </summary>
        /// <param name="text">Строка, которую следует записать</param>
        /// <param name="stream">Поток для записи</param>
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            int level=-1;
            using (StreamReader fs = new StreamReader(filename))
            {
                string temp = fs.ReadLine();
                if (temp.Contains("CountLeveles:"))
                {
                    if (garagesStages != null)
                    {
                        garagesStages.Clear();
                    }
                    garagesStages = new List<Garages<ITransport>>();
                } else
                {
                    throw new Exception("Invalid file format");
                }

                while (!fs.EndOfStream)
                {
                    temp = fs.ReadLine();
                    if (temp.Contains("Level"))
                    {
                        garagesStages.Add(new Garages<ITransport>(countPlaces,pictureWidth,pictureHeight));
                        level++;
                    } else if (temp.Contains("Truck"))
                    {
                        int index = Convert.ToInt32(temp.Split(':')[0]);
                        ITransport truck = null;
                        if (temp.Contains("FuelTruck"))
                        {
                            truck = new FuelTruck(temp.Split(':')[2]);
                        } else
                        {
                            truck = new Truck(temp.Split(':')[2]);
                        }
                        garagesStages[level][index] = truck;
                    }
                }
            }
            return true;
        }
    }
}
