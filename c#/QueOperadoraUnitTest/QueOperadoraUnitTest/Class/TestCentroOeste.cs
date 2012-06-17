using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using QueOperadora.Class;

namespace QueOperadoraUnitTest.Class
{
	[TestFixture]
	public class TestCentroOeste
	{
		QueOperadora.Class.Operadora m_operadora = new Operadora( );

		[Test]
		public void TestClaro1( )
		{
			for( int i = 61; i < 70; i++ )
			{
				for( int j = 9551; j < 9560; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "CLARO", m_opera );
				}
			}
		}

		[Test]
		public void TestOi1( )
		{
			for( int i = 61; i < 70; i++ )
			{
				string m_cel = i.ToString( ) + "86";

				string m_opera = m_operadora.CM_QueOperadora( m_cel );

				Assert.AreEqual( "OI", m_opera );
			}
		}

		[Test]
		public void TestTim( )
		{
			for( int i = 61; i < 70; i++ )
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
		public void TestOi2( )
		{
			for( int i = 61; i < 70; i++ )
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
		public void TestClaro2( )
		{
			for( int i = 61; i < 70; i++ )
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
			for( int i = 61; i < 70; i++ )
			{
				for( int j = 96; j < 100; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "VIVO", m_opera );
				}
			}
		}
	}
}
