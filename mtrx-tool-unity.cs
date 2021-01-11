/*
 * Created by SharpDevelop.
 * User: 18565
 * Date: 1/10/2021
 * Time: 5:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace test_matrix
{
	/// <summary>
	/// Description of mtrx_tool_unity.
	/// </summary>
	public class mtrx_tool_unity
	{
		
		public static int[,] generateSquareMatrix(int size = 256)
		{
			System.Random rand = new System.Random();
			
			int[,] matrix = new int[size,size];
			
			for(int i=0; i<256; i++)
			{
				for(int j=0; j<256; j++)
				{
					matrix[i,j] = rand.Next(0,255);
				}
			}
			
			return matrix;
		}
		
	}
}
