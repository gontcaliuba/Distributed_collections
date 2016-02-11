using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD02v4
{
    [Serializable]
    public class AvgSalary
    {
        int number;
        float sum;

        public AvgSalary() { }
        public AvgSalary(int number, float sum)
        {
            this.number = number;
            this.sum = sum;
        }

        public void addValues(int num, float sum)
        {
            number += num;
            this.sum += sum;
        }

        public float getAvgSalary()
        {
            if (this.number == 0) return 0;
            float avgSal = this.sum / this.number;
            return avgSal;
        }
        public static byte[] getBytes(AvgSalary avgSalaryInst) 
        {
            byte[] bytesNum = BitConverter.GetBytes(avgSalaryInst.number);
            byte[] bytesSum = BitConverter.GetBytes(avgSalaryInst.sum);
            byte[] bytesNumSum = new byte[bytesNum.Length + bytesSum.Length];
            Buffer.BlockCopy(bytesNum, 0, bytesNumSum, 0, bytesNum.Length);
            Buffer.BlockCopy(bytesSum, 0, bytesNumSum, bytesNum.Length, bytesSum.Length);
            return bytesNumSum;
        }

        public static AvgSalary getAvgSalary(byte[] bytes)
        {
            byte[] bytesNum = { 0, 0, 0, 0 };
            Array.Copy(bytes, bytesNum, 4);
            byte[] bytesSum = { 0, 0, 0, 0 };
            Array.Copy(bytes, 4, bytesSum, 0, 4);
            AvgSalary avgSal = new AvgSalary(
                BitConverter.ToInt32(bytesNum, 0), BitConverter.ToSingle(bytesSum, 0));
            return avgSal;
        }



    }
}
