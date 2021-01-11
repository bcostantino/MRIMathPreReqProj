/*
 * Created by SharpDevelop.
 * User: 18565
 * Date: 1/8/2021
 * Time: 3:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Drawing;

namespace test_matrix
{
	public class origProgClass
	{
		/*
		private void Main()
		{
			int[,] myMatrix = generateSquareMatrix(256);
			//printMatrix(myMatrix);
			
			Image img = drawMap();
			Console.WriteLine(img);
			
			Console.ReadKey();
		}
		*/
		
		public static void printMatrix(int[,] matrix, int fmt=0)
		{
			int rowLength = matrix.GetLength(0);
        	int colLength = matrix.GetLength(1);
        	
	        for (int i = 0; i < rowLength; i++)
	        {
	            for (int j = 0; j < colLength; j++)
	            {
	                Console.Write(string.Format("{0} ", matrix[i, j]));
	            }
	            
	            Console.Write(Environment.NewLine + Environment.NewLine);
	        }
	        if(fmt==0)
	        {
	        	Console.WriteLine(rowLength.ToString()+"x"+colLength.ToString());
	        }
	        else if(fmt==1)
	        {
	        	Console.WriteLine("Rows: "+rowLength.ToString()+"\nColumns: "+colLength.ToString());
	        }
		}
		
		public static Bitmap generateBitmap(int[,] matrix)
		{
			int rowLength = matrix.GetLength(0);
			int colLength = matrix.GetLength(1);
			
			Bitmap bitmap = new Bitmap(rowLength, colLength);
			
			for (int i = 0; i < rowLength; i++)
	        {
	            for (int j = 0; j < colLength; j++)
	            {
	            	int val = matrix[i,j];
	            	bitmap.SetPixel(i, j, Color.FromArgb(0, val, val, val));
	            }

	        }
			
			return bitmap;
		}
		
		public static int[,] generateSquareMatrix(int size = 256)
		{
			System.Random random = new System.Random();
			
			int[,] matrix = new int[size,size];
			
			for(int i=0; i<256; i++)
			{
				for(int j=0; j<256; j++)
				{
					matrix[i,j] = random.Next(0,255);
				}
			}
			
			return matrix;
		}
		
		public static Image byteArrayToImage(byte[] byteArray)
		{
			using (var ms = new MemoryStream(byteArray))
			{
			    return Image.FromStream(ms);
			}
		}
		
		public static Image drawMap() 
		{ 
			var codeBitmap = new Bitmap(256,256);
			Image image = (Image)codeBitmap;
			
			return image;
		}
	}
}