/*
 * Created by SharpDevelop.
 * User: 18565
 * Date: 1/8/2021
 * Time: 3:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace test_matrix
{
	class Program
	{
		public static void Main()
		{
			
			int[,] myMatrix = origProgClass.generateSquareMatrix(256);
			//printMatrix(myMatrix);
			
			origProgClass.printMatrix(myMatrix);
			
			Bitmap myBitmap = origProgClass.generateBitmap(myMatrix);
			
			Console.Write(myBitmap);
			
			Console.ReadKey();
		}
	}
}