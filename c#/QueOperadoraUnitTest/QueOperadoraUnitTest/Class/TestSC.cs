using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using QueOperadora.Class;

namespace QueOperadoraUnitTest.Class
{
	[TestFixture]
	public class TestSC
	{
		QueOperadora.Class.Operadora m_operadora = new Operadora( );

		[Test]
		public void TestTim1( )
		{
			string m_cel = "4381";

			string m_opera = m_operadora.CM_QueOperadora( m_cel );

			Assert.AreEqual( "TIM", m_opera );
		}

		[Test]
		public void TestSERCOMTEL( )
		{
			for( int i = 9941; i < 9999; i++ )
			{
				string m_cel = "43" + i.ToString( );

				string m_opera = m_operadora.CM_QueOperadora( m_cel );

				Assert.AreEqual( "SERCOMTEL", m_opera );
			}
		}

		[Test]
		public void TestOi( )
		{
			for( int i = 41; i < 50; i++ )
			{
				for( int j = 84; j < 86; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "OI", m_opera );
				}	
			}
		}

		[Test]
		public void TestClaro( )
		{
			for( int i = 41; i < 50; i++ )
			{
				for( int j = 87; j < 89; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "CLARO", m_opera );
				}
			}
		}

		[Test]
		public void TestVivo( )
		{
			for( int i = 41; i < 50; i++ )
			{
				for( int j = 91; j < 95; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "VIVO", m_opera );
				}
			}
		}

		[Test]
		public void TestTim2( )
		{
			for( int i = 41; i < 50; i++ )
			{
				for( int j = 96; j < 100; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "TIM", m_opera );
				}
			}
		}
	}
}
