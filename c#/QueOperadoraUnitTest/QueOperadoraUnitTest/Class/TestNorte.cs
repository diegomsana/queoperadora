using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using QueOperadora.Class;

namespace QueOperadoraUnitTest.Class
{
	[TestFixture]
	public class TestNorte
	{
		QueOperadora.Class.Operadora m_operadora = new Operadora( );

		[Test]
		public void TestOi1( )
		{
			for( int i = 91; i < 100; i++ )
			{
				for( int j = 80; j < 84; j++ )
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
			for( int i = 91; i < 100; i++ )
			{
				string m_cel = i.ToString( ) + "84";

				string m_opera = m_operadora.CM_QueOperadora( m_cel );

				Assert.AreEqual( "CLARO", m_opera );
			}
		}

		[Test]
		public void TestOi2( )
		{
			for( int i = 91; i < 100; i++ )
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
		public void TestAmazoniaCelular( )
		{
			for( int i = 91; i < 100; i++ )
			{
				for( int j = 96; j < 95; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "OI", m_opera );
				}
			}
		}
	}
}
