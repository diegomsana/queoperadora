using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using task = Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;

namespace QueOperadora
{
	public partial class MainPage : PhoneApplicationPage
	{
		task.SaveContactTask saveContactTask;
		task.PhoneCallTask phoneCallTask;

		// Constructor
		public MainPage( )
		{
			InitializeComponent( );

			phoneCallTask = new task.PhoneCallTask( );

			saveContactTask = new task.SaveContactTask( );
			saveContactTask.Completed += new EventHandler<task.SaveContactResult>( saveContactTask_Completed );
		}

		/// 2012 05 19 - Césare
		/// <summary>
		/// Capturando o evento após completar a ação de adicionar contato
		/// </summary>
		void saveContactTask_Completed( object sender, task.SaveContactResult e )
		{
			if( e.TaskResult == task.TaskResult.OK )
				MessageBox.Show( "Contato salvo!", "Atenção", MessageBoxButton.OK );
		}

		/// 2012 05 19 - Césare
		/// <summary>
		/// Vamos adicionar aos contatos o número digitado pelo usuário
		/// </summary>
		private void btn_addContatos_Click( object sender, RoutedEventArgs e )
		{
			saveContactTask.MobilePhone = txt_numeroCelular.Text;
			saveContactTask.Show( );
		}

		/// 2012 05 19 - Césare
		/// <summary>
		/// Setando o telefone a ser discado e chamando o launcher de ligação
		/// </summary>
		private void btn_ligar_Click( object sender, RoutedEventArgs e )
		{
			phoneCallTask.PhoneNumber = txt_numeroCelular.Text;
			phoneCallTask.Show( );
		}

		/// 2012 05 19 - Césare
		/// <summary>
		/// Habilita/Desabilita os botões de ligação/contato de acordo
		/// com o texto digitado
		/// </summary>
		private void txt_numeroCelular_TextChanged( object sender, TextChangedEventArgs e )
		{
			btn_addContatos.IsEnabled = !string.IsNullOrWhiteSpace( txt_numeroCelular.Text );
			btn_ligar.IsEnabled = !string.IsNullOrWhiteSpace( txt_numeroCelular.Text );
		}

		/// 2012 05 19 - Césare
		/// <summary>
		/// Verificando qual a operadora do celular que o usuário digitou
		/// </summary>
		private void txt_numeroCelular_KeyUp( object sender, KeyEventArgs e )
		{
			Class.Operadora m_operadora = new Class.Operadora( );
			string m_retorno = m_operadora.CM_QueOperadora( txt_numeroCelular.Text );

			switch( m_retorno )
			{
				case "TIM":
					BitmapImage m_tim = new BitmapImage( new Uri( "Images/tim.png", UriKind.RelativeOrAbsolute ) );
					img_operadora.Source = m_tim;

					break;
				case "VIVO":
					BitmapImage m_vivo = new BitmapImage( new Uri( "Images/vivo.png", UriKind.RelativeOrAbsolute ) );
					img_operadora.Source = m_vivo;

					break;
				case "CLARO":
					BitmapImage m_claro = new BitmapImage( new Uri( "Images/claro.png", UriKind.RelativeOrAbsolute ) );
					img_operadora.Source = m_claro;

					break;
				case "OI":
					BitmapImage m_oi = new BitmapImage( new Uri( "Images/oi.png", UriKind.RelativeOrAbsolute ) );
					img_operadora.Source = m_oi;

					break;
				case "CTBC":
					BitmapImage m_ctbc = new BitmapImage( new Uri( "Images/ctbc.png", UriKind.RelativeOrAbsolute ) );
					img_operadora.Source = m_ctbc;

					break;
				case "SERCOMTEL":
					BitmapImage m_sercomtel = new BitmapImage( new Uri( "Images/sercomtel.gif", UriKind.RelativeOrAbsolute ) );
					img_operadora.Source = m_sercomtel;

					break;
				default:
					BitmapImage m_nenhuma = new BitmapImage( new Uri( "Images/nenhuma.png", UriKind.RelativeOrAbsolute ) );
					img_operadora.Source = m_nenhuma;

					break;
			}
		}
	}
}