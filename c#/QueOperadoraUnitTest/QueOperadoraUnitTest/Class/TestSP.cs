using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using QueOperadora.Class;

namespace QueOperadoraUnitTest.Class
{
	[TestFixture]
	public class TestSP
	{
		QueOperadora.Class.Operadora m_operadora = new Operadora( );

		[Test]
		public void TestTim1( )
		{
			for( int i = 11; i < 20; i++ )
			{
				for( int j = 6340; j < 6370; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "TIM", m_opera );
				}
			}
		}

		[Test]
		public void TestClaro1( )
		{
			for( int i = 11; i < 20; i++ )
			{
				for( int j = 6300; j < 6340; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "CLARO", m_opera );
				}
			}
		}

		[Test]
		public void TestClaro2( )
		{
			for( int i = 11; i < 20; i++ )
			{
				for( int j = 6168; j < 6182; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "CLARO", m_opera );
				}
			}
		}

		[Test]
		public void TestClaro3( )
		{
			for( int i = 11; i < 20; i++ )
			{
				for( int j = 6589; j < 6600; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "CLARO", m_opera );
				}
			}
		}

		[Test]
		public void TestClaro4( )
		{
			for( int i = 11; i < 20; i++ )
			{
				for( int j = 7052; j < 7063; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "CLARO", m_opera );
				}
			}
		}

		[Test]
		public void TestClaro5( )
		{
			for( int i = 11; i < 20; i++ )
			{
				string m_cel = i.ToString( ) + "76";

				string m_opera = m_operadora.CM_QueOperadora( m_cel );

				Assert.AreEqual( "CLARO", m_opera );
			}
		}

		[Test]
		public void TestClaro6( )
		{
			for( int i = 11; i < 20; i++ )
			{
				for( int j = 8800; j < 8900; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "CLARO", m_opera );
				}
			}
		}

		[Test]
		public void TestVivo1( )
		{
			for( int i = 11; i < 20; i++ )
			{
				for( int j = 6057; j < 6061; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "VIVO", m_opera );
				}
			}
		}

		[Test]
		public void TestVivo2( )
		{
			for( int i = 11; i < 20; i++ )
			{
				for( int j = 6182; j < 6200; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "VIVO", m_opera );
				}
			}
		}

		[Test]
		public void TestVivo3( )
		{
			for( int i = 11; i < 20; i++ )
			{
				for( int j = 6370; j < 6500; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "VIVO", m_opera );
				}
			}
		}

		[Test]
		public void TestVivo4( )
		{
			for( int i = 11; i < 20; i++ )
			{
				string m_cel = i.ToString( ) + "7099";

				string m_opera = m_operadora.CM_QueOperadora( m_cel );

				Assert.AreEqual( "VIVO", m_opera );
			}
		}


		[Test]
		public void TestVivo5( )
		{
			for( int i = 11; i < 20; i++ )
			{
				for( int j = 71; j < 76; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "VIVO", m_opera );
				}
			}
		}

		[Test]
		public void TestVivo6( )
		{
			for( int i = 11; i < 20; i++ )
			{
				string m_cel = i.ToString( ) + "95";

				string m_opera = m_operadora.CM_QueOperadora( m_cel );

				Assert.AreEqual( "VIVO", m_opera );
			}
		}

		[Test]
		public void TestVivo7( )
		{
			for( int i = 11; i < 20; i++ )
			{
				string m_cel = i.ToString( ) + "99";

				string m_opera = m_operadora.CM_QueOperadora( m_cel );

				Assert.AreEqual( "VIVO", m_opera );
			}
		}

		[Test]
		public void TestOi1( )
		{
			for( int i = 11; i < 20; i++ )
			{
				for( int j = 6100; j < 6168; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "OI", m_opera );
				}
			}
		}

		[Test]
		public void TestOi2( )
		{
			for( int i = 11; i < 20; i++ )
			{
				for( int j = 6200; j < 6300; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "OI", m_opera );
				}
			}
		}

		[Test]
		public void TestOi3( )
		{
			for( int i = 11; i < 20; i++ )
			{
				string m_cel = i.ToString( ) + "65";

				string m_opera = m_operadora.CM_QueOperadora( m_cel );

				Assert.AreEqual( "OI", m_opera );
			}
		}

		[Test]
		public void TestOi4( )
		{
			for( int i = 11; i < 20; i++ )
			{
				for( int j = 6651; j < 6800; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "OI", m_opera );
				}
			}
		}

		[Test]
		public void TestOi5( )
		{
			for( int i = 11; i < 20; i++ )
			{
				string m_cel = i.ToString( ) + "68";

				string m_opera = m_operadora.CM_QueOperadora( m_cel );

				Assert.AreEqual( "OI", m_opera );
			}
		}

		[Test]
		public void TestOi6( )
		{
			for( int i = 11; i < 20; i++ )
			{
				string m_cel = i.ToString( ) + "6999";

				string m_opera = m_operadora.CM_QueOperadora( m_cel );

				Assert.AreEqual( "OI", m_opera );
			}
		}

		[Test]
		public void TestOi7( )
		{
			for( int i = 11; i < 20; i++ )
			{
				for( int j = 7971; j < 8000; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "OI", m_opera );
				}
			}
		}

		[Test]
		public void TestOi8( )
		{
			for( int i = 11; i < 20; i++ )
			{
				for( int j = 8010; j < 8100; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "OI", m_opera );
				}
			}
		}

		[Test]
		public void TestTim2( )
		{
			for( int i = 11; i < 20; i++ )
			{
				for( int j = 81; j < 88; j++ )
				{
					string m_cel = i.ToString( ) + j.ToString( );

					string m_opera = m_operadora.CM_QueOperadora( m_cel );

					Assert.AreEqual( "TIM", m_opera );
				}
			}
		}

		[Test]
		public void TestClaro8( )
		{
			for( int i = 11; i < 20; i++ )
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
		public void TestVivo8( )
		{
			for( int i = 11; i < 20; i++ )
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
