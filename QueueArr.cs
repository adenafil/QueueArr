using System;
using System.Runtime.Serialization;

namespace tes
{
    public class QueueArr
    {
        int[] ArrayData;
        int Front;
        int Back;
        int MaxSize;

        public QueueArr(int maxSize)
        {
            this.ArrayData = new int[maxSize];
            this.MaxSize = maxSize;
            Front = Back = -1;
        }

        public bool IsEmpty()
        {
            return Front == -1;
        }

        public void Enqueue(int data)
        {
            if (IsEmpty())
            {
                Front = Back = 0;
                ArrayData[Back] = data;
            }
            else
            {
                int nextBack = (Back + 1) % MaxSize;

                if (nextBack == Front)
                {
                    Console.WriteLine("Queue Sudah Penuh");
                    return;
                }
                else
                {
                    Back = nextBack;
                    ArrayData[Back] = data;
                }
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Masih Kosong");
                return -1;
            }
            else
            {
                int retData = ArrayData[Front];
                if (Front == Back)
                {
                    Front = Back = -1;
                }
                else
                {
                    Front = (Front + 1) % MaxSize;
                }
                return retData;
            }
        }

        public int First()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Masih Kosong");
                return -1;
            }
            else
            {
                return ArrayData[Front];
            }
        }

        public int Size()
        {
            if (IsEmpty())
            {
                return -1;
            }
            else
            {
                return (Back - Front + MaxSize) % MaxSize + 1;
            }
        }

    }
}