using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace QueOperadora.Class
{
	public class Operadora
	{
		/// <summary>
		/// Define o range de operadoras suportadas pelo algoritmo
		/// </summary>
		private enum E_OPERADORA
		{
			TIM,
			CLARO,
			VIVO,
			CTBC,
			OI,
			SERCOMTEL,
			NENHUMA
		};


		/// Eduardo Orige/Césare Cibien
		/// <summary>
		/// <para>Verifica corretamente seguindo o padrao anterior de numero de celular: 99 9999-9999</para>
		/// <para>Se padrão nao for seguido, função retorna False.</para>
		/// <para>Primeiro verifica-se as exceções dos prefixos com 4 digitos depois então verifica-se </para>
		/// <para>os numeros "padroes".</para>
		/// </summary>
		/// <param name="p_celular">O número de celular a ser verificado</param>
		/// <returns>A operadora do celular</returns>
		public string CM_QueOperadora( string p_celular )
		{
			if( string.IsNullOrWhiteSpace( p_celular ) || p_celular.Length < 6 )
				return E_OPERADORA.NENHUMA.ToString( );

			int m_ddd = Convert.ToInt32( p_celular.Substring( 0, 2 ) );
			int m_cel = Convert.ToInt32( p_celular.Substring( 2, 2 ) );
			int m_pre_cel = Convert.ToInt32( p_celular.Substring( 2, 4 ) );

			/// 
			/// SP
			/// 
			if( cm_EstaEntre( m_ddd, 11, 19 ) )
			{
				if( cm_EstaEntre( m_pre_cel, 6340, 6369 ) )
					return E_OPERADORA.TIM.ToString( );

				else if( cm_EstaEntre( m_pre_cel, 6310, 6339 ) ||
					    cm_EstaEntre( m_pre_cel, 6589, 6599 ) ||
					    cm_EstaEntre( m_pre_cel, 7052, 7062 ) ||
					    m_cel == 76 ||
					    cm_EstaEntre( m_pre_cel, 8800, 8899 ) ||
					    m_cel == 89 )
					return E_OPERADORA.CLARO.ToString( );

				else if( cm_EstaEntre( m_pre_cel, 6057, 6060 ) ||
					 cm_EstaEntre( m_pre_cel, 6193, 6199 ) ||
					 m_pre_cel == 7099 ||
					 cm_EstaEntre( m_cel, 71, 75 ) ||
					 m_cel == 95 )
					return E_OPERADORA.VIVO.ToString( );

				else if( cm_EstaEntre( m_pre_cel, 6100, 6193 ) ||
					m_pre_cel == 6299 ||
					m_cel == 65 ||
					cm_EstaEntre( m_pre_cel, 6651, 6799 ) ||
					m_pre_cel == 6999 ||
					cm_EstaEntre( m_pre_cel, 7971, 7999 ) ||
					m_cel == 80 ||
					cm_EstaEntre( m_pre_cel, 8814, 8899 ) )
					return E_OPERADORA.OI.ToString( );

				else
				{
					if( m_cel == 80 || m_cel == 88 || m_cel == 89 )
						return E_OPERADORA.OI.ToString( );

					else if( cm_EstaEntre( m_cel, 81, 87 ) )
						return E_OPERADORA.TIM.ToString( );

					else if( cm_EstaEntre( m_cel, 91, 94 ) )
						return E_OPERADORA.CLARO.ToString( );

					else if( cm_EstaEntre( m_cel, 96, 99 ) )
						return E_OPERADORA.VIVO.ToString( );
				}
			}
			/// RJ e ES
			else if( cm_EstaEntre( m_ddd, 21, 28 ) )
			{
				if( m_cel == 71 || m_cel == 72 || m_cel == 95 )
					return E_OPERADORA.VIVO.ToString( );

				else if( cm_EstaEntre( m_cel, 74, 76 ) )
					return E_OPERADORA.CLARO.ToString( );

				else if( cm_EstaEntre( m_cel, 80, 83 ) )
					return E_OPERADORA.TIM.ToString( );

				else if( cm_EstaEntre( m_cel, 84, 86 ) || cm_EstaEntre( m_cel, 87, 89 ) )
					return E_OPERADORA.OI.ToString( );

				else if( cm_EstaEntre( m_cel, 91, 94 ) )
					return E_OPERADORA.CLARO.ToString( );

				else if( cm_EstaEntre( m_cel, 96, 99 ) )
					return E_OPERADORA.VIVO.ToString( );

				else
					return E_OPERADORA.NENHUMA.ToString( );
			}
			/// MG
			else if( cm_EstaEntre( m_ddd, 31, 38 ) )
			{
				if( cm_EstaEntre( m_cel, 81, 84 ) )
					return E_OPERADORA.CLARO.ToString( );

				else if( m_cel == 85 || m_cel == 86 || m_cel == 89 )
					return E_OPERADORA.CLARO.ToString( );

				else if( cm_EstaEntre( m_cel, 87, 88 ) )
					return E_OPERADORA.TIM.ToString( );

				else if( cm_EstaEntre( m_cel, 91, 94 ) )
					return E_OPERADORA.TIM.ToString( );

				else if( cm_EstaEntre( m_cel, 96, 99 ) )
					return E_OPERADORA.VIVO.ToString( );

				else if( cm_EstaEntre( m_pre_cel, 9960, 9979 ) || cm_EstaEntre( m_pre_cel, 9991, 9999 ) )
					return E_OPERADORA.CTBC.ToString( );

				else
					return E_OPERADORA.NENHUMA.ToString( );
			}
			/// SC e PR
			else if( cm_EstaEntre( m_ddd, 41, 49 ) )
			{
				if( m_ddd == 43 && m_cel == 81 )
					return E_OPERADORA.TIM.ToString( );
				else
				{
					if( cm_EstaEntre( m_cel, 84, 85 ) )
						return E_OPERADORA.OI.ToString( );

					else if( cm_EstaEntre( m_cel, 87, 88 ) )
						return E_OPERADORA.CLARO.ToString( );

					else if( cm_EstaEntre( m_cel, 91, 94 ) )
						return E_OPERADORA.VIVO.ToString( );

					else if( cm_EstaEntre( m_cel, 96, 99 ) )
						return E_OPERADORA.TIM.ToString( );

					else
						return E_OPERADORA.NENHUMA.ToString( );
				}
			}
			/// RS
			else if( cm_EstaEntre( m_ddd, 51, 55 ) )
			{
				if( cm_EstaEntre( m_cel, 81, 82 ) )
					return E_OPERADORA.TIM.ToString( );

				else if( cm_EstaEntre( m_cel, 84, 85 ) )
					return E_OPERADORA.OI.ToString( );

				else if( cm_EstaEntre( m_cel, 91, 94 ) )
					return E_OPERADORA.CLARO.ToString( );

				else if( cm_EstaEntre( m_cel, 95, 99 ) )
					return E_OPERADORA.VIVO.ToString( );

				else
					return E_OPERADORA.NENHUMA.ToString( );
			}
			/// Centro Oeste
			else if( cm_EstaEntre( m_ddd, 61, 69 ) )
			{
				if( cm_EstaEntre( m_pre_cel, 9551, 9559 ) )
					return E_OPERADORA.CLARO.ToString( );

				else if( m_cel == 86 )
					return E_OPERADORA.OI.ToString( );

				else
				{
					if( cm_EstaEntre( m_cel, 81, 82 ) )
						return E_OPERADORA.TIM.ToString( );

					else if( cm_EstaEntre( m_cel, 84, 85 ) )
						return E_OPERADORA.OI.ToString( );

					else if( cm_EstaEntre( m_cel, 91, 94 ) )
						return E_OPERADORA.CLARO.ToString( );

					else if( cm_EstaEntre( m_cel, 96, 99 ) )
						return E_OPERADORA.VIVO.ToString( );

					else
						return E_OPERADORA.NENHUMA.ToString( );
				}
			}
			/// BA e SE
			else if( cm_EstaEntre( m_ddd, 71, 79 ) )
			{
				if( cm_EstaEntre( m_cel, 81, 83 ) )
					return E_OPERADORA.CLARO.ToString( );

				else if( cm_EstaEntre( m_cel, 86, 88 ) )
					return E_OPERADORA.OI.ToString( );

				else if( cm_EstaEntre( m_cel, 91, 94 ) )
					return E_OPERADORA.TIM.ToString( );

				else if( cm_EstaEntre( m_cel, 96, 99 ) )
					return E_OPERADORA.TIM.ToString( );

				else
					return E_OPERADORA.NENHUMA.ToString( );
			}
			/// Nordeste
			else if( cm_EstaEntre( m_ddd, 81, 89 ) )
			{
				if( cm_EstaEntre( m_cel, 84, 86 ) )
					return E_OPERADORA.OI.ToString( );

				else if( cm_EstaEntre( m_pre_cel, 8719, 8721 ) || m_cel == 88 )
					return E_OPERADORA.TIM.ToString( );

				else
				{
					if( cm_EstaEntre( m_cel, 81, 83 ) )
						return E_OPERADORA.VIVO.ToString( );

					else if( cm_EstaEntre( m_cel, 87, 88 ) )
						return E_OPERADORA.OI.ToString( );

					else if( cm_EstaEntre( m_cel, 91, 94 ) )
						return E_OPERADORA.CLARO.ToString( );

					else if( cm_EstaEntre( m_cel, 96, 99 ) )
						return E_OPERADORA.TIM.ToString( );

					else
						return E_OPERADORA.NENHUMA.ToString( );
				}
			}
			/// Norte
			else if( cm_EstaEntre( m_ddd, 91, 99 ) )
			{
				if( cm_EstaEntre( m_cel, 80, 83 ) )
					return E_OPERADORA.OI.ToString( );

				else if( m_cel == 84 )
					return E_OPERADORA.CLARO.ToString( );

				else if( cm_EstaEntre( m_cel, 87, 88 ) )
					return E_OPERADORA.OI.ToString( );

				else if( cm_EstaEntre( m_cel, 91, 94 ) )
					return E_OPERADORA.VIVO.ToString( );

				else
					return E_OPERADORA.NENHUMA.ToString( );
			}

			return E_OPERADORA.NENHUMA.ToString( );
		}

		private bool cm_EstaEntre( int p_valorComprar, int p_valor1, int p_valor2 )
		{
			return p_valorComprar >= p_valor1 && p_valorComprar <= p_valor2;
		}
	}
}
