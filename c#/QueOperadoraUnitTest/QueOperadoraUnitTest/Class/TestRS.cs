using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using QueOperadora.Class;

namespace QueOperadoraUnitTest.Class
{
	[TestFixture]
	public class TestRS
	{
		QueOperadora.Class.Operadora m_operadora = new Operadora( );

		[Test]
		public void TestTim_Pelotas( )
		{
			for( int i = 9911; i < 9921; i++ )
			{
				string m_cel = "53" + i.ToString( );

				string m_opera = m_operadora.CM_QueOperadora( m_cel );

				Assert.AreEqual( "TIM", m_opera );
			}
		}

		[Test]
		public void TestTim( )
		{
			for( int i = 51; i < 56; i++ )
			{
				for( int j = 81; j < 83; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "TIM", m_opera );
				}
			}
		}

		[Test]
		public void TestOi( )
		{
			for( int i = 51; i < 56; i++ )
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
			for( int i = 51; i < 56; i++ )
			{
				for( int j = 91; j < 95; j++ )
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
			for( int i = 51; i < 53; i++ )
			{
				for( int j = 9500; j < 9911; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "VIVO", m_opera );
				}

				for( int j = 9921; j < 10000; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "VIVO", m_opera );
				}
			}
		}
	}
}
