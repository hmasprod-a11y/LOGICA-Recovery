using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace LOGICA.My;

[StandardModule]
[GeneratedCode("MyTemplate", "14.0.0.0")]
[HideModuleName]
internal sealed class MyProject
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class MyForms
	{
		public Form_00_BACKOFFICE m_Form_00_BACKOFFICE;

		public Form_0_TEMPLATE m_Form_0_TEMPLATE;

		public Form_1_LOGIN m_Form_1_LOGIN;

		public Form_2_ARTICLES m_Form_2_ARTICLES;

		public Form_2_Familles m_Form_2_Familles;

		public Form_3_VENTE m_Form_3_VENTE;

		public Form_3_VENTE_ENTETE m_Form_3_VENTE_ENTETE;

		public Form_3_VENTE_JOURNAL m_Form_3_VENTE_JOURNAL;

		public Form_3_VENTE_MARGE m_Form_3_VENTE_MARGE;

		public Form_3_VENTE_RETOURS m_Form_3_VENTE_RETOURS;

		public Form_5_CLIENTS m_Form_5_CLIENTS;

		public Form_5_CLIENTS_ETAT_CREDITS m_Form_5_CLIENTS_ETAT_CREDITS;

		public Form_5_CLIENTS_HISTORIQUE_CREDIT_INITIAL m_Form_5_CLIENTS_HISTORIQUE_CREDIT_INITIAL;

		public Form_5_CLIENTS_LISTE m_Form_5_CLIENTS_LISTE;

		public Form_5_CLIENTS_MODIFICATION_CREDIT_INITIAL m_Form_5_CLIENTS_MODIFICATION_CREDIT_INITIAL;

		public Form_5_CLIENTS_RDV m_Form_5_CLIENTS_RDV;

		public Form_5_CLIENTS_REGLE m_Form_5_CLIENTS_REGLE;

		public Form_5_VENDEURS_LISTE m_Form_5_VENDEURS_LISTE;

		public Form_6_COMMANDES m_Form_6_COMMANDES;

		public Form_6_DEPENSES m_Form_6_DEPENSES;

		public Form_6_FOURNISSEURS m_Form_6_FOURNISSEURS;

		public Form_6_FOURNISSEURS_ETAT_CREDITS m_Form_6_FOURNISSEURS_ETAT_CREDITS;

		public Form_6_FOURNISSEURS_HISTORIQUE_CREDIT_INITIAL m_Form_6_FOURNISSEURS_HISTORIQUE_CREDIT_INITIAL;

		public Form_6_FOURNISSEURS_LISTE m_Form_6_FOURNISSEURS_LISTE;

		public Form_6_FOURNISSEURS_MODIFICATION_CREDIT_INITIAL m_Form_6_FOURNISSEURS_MODIFICATION_CREDIT_INITIAL;

		public Form_6_FOURNISSEURS_REGLE m_Form_6_FOURNISSEURS_REGLE;

		public Form_6_INVENTAIRES m_Form_6_INVENTAIRES;

		public Form_6_MOUVEMENTS_STOCK m_Form_6_MOUVEMENTS_STOCK;

		public Form_6_RECEPTIONS m_Form_6_RECEPTIONS;

		public Form_6_SORTIES m_Form_6_SORTIES;

		public Form_8_gestion m_Form_8_gestion;

		public Form_90000_FACTURE m_Form_90000_FACTURE;

		public Form_9000_BL m_Form_9000_BL;

		public Form_900_DEVIS m_Form_900_DEVIS;

		public Form_9_PARAMETRE m_Form_9_PARAMETRE;

		public Form_9_STATISTIQUES m_Form_9_STATISTIQUES;

		public FormDialog_1_UTILISATEURS m_FormDialog_1_UTILISATEURS;

		public FormDialog_2_Configuration m_FormDialog_2_Configuration;

		public FormDialog_3_Configuration_Suite m_FormDialog_3_Configuration_Suite;

		public FormDialog_4_Configuration_Suite m_FormDialog_4_Configuration_Suite;

		public FormDialog_5_MODE_P m_FormDialog_5_MODE_P;

		public FormDialog_8_BASE_DONNEE m_FormDialog_8_BASE_DONNEE;

		public FormDialog_acces_ADMIN m_FormDialog_acces_ADMIN;

		public FormDialog_acces_MANAGER m_FormDialog_acces_MANAGER;

		public FormDialog_AFFICHEUR_2 m_FormDialog_AFFICHEUR_2;

		public FormDialog_ALERT_ERREUR m_FormDialog_ALERT_ERREUR;

		public FormDialog_ARTICLE_INCONNU m_FormDialog_ARTICLE_INCONNU;

		public FormDialog_ATTENTES m_FormDialog_ATTENTES;

		public FormDialog_ATTRIBUTIONS m_FormDialog_ATTRIBUTIONS;

		public FormDialog_BLOC_NOTE m_FormDialog_BLOC_NOTE;

		public FormDialog_calc m_FormDialog_calc;

		public FormDialog_CLAVIER m_FormDialog_CLAVIER;

		public FormDialog_CLOTURE m_FormDialog_CLOTURE;

		public FormDialog_COMPTER_CAISSE m_FormDialog_COMPTER_CAISSE;

		public FormDialog_DIVERS m_FormDialog_DIVERS;

		public FormDialog_DUPLICATA m_FormDialog_DUPLICATA;

		public FormDialog_ETAT_ALERTES_STOCK m_FormDialog_ETAT_ALERTES_STOCK;

		public FormDialog_ETAT_ALERTS_PEREMPTION m_FormDialog_ETAT_ALERTS_PEREMPTION;

		public FormDialog_ETAT_INVENTAIRE m_FormDialog_ETAT_INVENTAIRE;

		public FormDialog_ETAT_LISTE_ARTICLES m_FormDialog_ETAT_LISTE_ARTICLES;

		public FormDialog_ETAT_STOCK m_FormDialog_ETAT_STOCK;

		public FormDialog_ETIQUETTE_AUTOC m_FormDialog_ETIQUETTE_AUTOC;

		public FormDialog_ETIQUETTE_AUTOC_A4 m_FormDialog_ETIQUETTE_AUTOC_A4;

		public FormDialog_FONDS_CAISSE m_FormDialog_FONDS_CAISSE;

		public FormDialog_google m_FormDialog_google;

		public FormDialog_IMPORTER_ARTICLES m_FormDialog_IMPORTER_ARTICLES;

		public FormDialog_info m_FormDialog_info;

		public FormDialog_LISTE_COULEURS m_FormDialog_LISTE_COULEURS;

		public FormDialog_LISTE_TAILLES m_FormDialog_LISTE_TAILLES;

		public FormDialog_MODE_P m_FormDialog_MODE_P;

		public FormDialog_MODIFICATION_PRIX m_FormDialog_MODIFICATION_PRIX;

		public FormDialog_MODIFICATION_QTE m_FormDialog_MODIFICATION_QTE;

		public FormDialog_MSGBOX_OK m_FormDialog_MSGBOX_OK;

		public FormDialog_MSGBOX_YES_NO m_FormDialog_MSGBOX_YES_NO;

		public FormDialog_PATIENTER m_FormDialog_PATIENTER;

		public FormDialog_PATIENTER_BALANCE m_FormDialog_PATIENTER_BALANCE;

		public FormDialog_PESEE_BALANCE m_FormDialog_PESEE_BALANCE;

		public FormDialog_PRIX_LIBRE m_FormDialog_PRIX_LIBRE;

		public FormDialog_QUANTITE m_FormDialog_QUANTITE;

		public FormDialog_QUITTER m_FormDialog_QUITTER;

		public FormDialog_RACCOURCIES m_FormDialog_RACCOURCIES;

		public FormDialog_RAPPORT m_FormDialog_RAPPORT;

		public FormDialog_REMISE m_FormDialog_REMISE;

		public FormDialog_RETOUR m_FormDialog_RETOUR;

		public FormDialog_RFID m_FormDialog_RFID;

		public FormDialog_ROBOT m_FormDialog_ROBOT;

		public FormDialog_THEME m_FormDialog_THEME;

		public JOURNAL_REGELEMENTS m_JOURNAL_REGELEMENTS;

		public Report_BC m_Report_BC;

		public Report_BL m_Report_BL;

		public Report_BR m_Report_BR;

		public Report_BS m_Report_BS;

		public Report_CLIENTS_ETAT_CREDITS m_Report_CLIENTS_ETAT_CREDITS;

		public Report_CLIENTS_ETAT_HISTORIQUE m_Report_CLIENTS_ETAT_HISTORIQUE;

		public Report_CLIENTS_ETAT_HISTORIQUE_DETAILS m_Report_CLIENTS_ETAT_HISTORIQUE_DETAILS;

		public Report_DEVIS m_Report_DEVIS;

		public Report_ETAT_STOCK m_Report_ETAT_STOCK;

		public Report_FACTURE m_Report_FACTURE;

		public Report_FOURNISSEURS_ETAT_CREDITS m_Report_FOURNISSEURS_ETAT_CREDITS;

		public Report_FOURNISSEURS_ETAT_HISTORIQUE m_Report_FOURNISSEURS_ETAT_HISTORIQUE;

		public Report_FOURNISSEURS_ETAT_HISTORIQUE_DETAILS m_Report_FOURNISSEURS_ETAT_HISTORIQUE_DETAILS;

		public Report_INVENTAIRE m_Report_INVENTAIRE;

		public Report_NOMENCLATURE m_Report_NOMENCLATURE;

		public Report_PEREMPTIONS m_Report_PEREMPTIONS;

		public Report_RAPPORT_IMPRESSION m_Report_RAPPORT_IMPRESSION;

		public Report_TICKET_80_ARABE m_Report_TICKET_80_ARABE;

		public Report_TICKET_A4 m_Report_TICKET_A4;

		public Report_TICKET_A5 m_Report_TICKET_A5;

		public Report_TICKET_A5_ARABE m_Report_TICKET_A5_ARABE;

		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		public Form_00_BACKOFFICE Form_00_BACKOFFICE
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_00_BACKOFFICE = Create__Instance__(m_Form_00_BACKOFFICE);
				return m_Form_00_BACKOFFICE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_00_BACKOFFICE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_00_BACKOFFICE);
				}
			}
		}

		public Form_0_TEMPLATE Form_0_TEMPLATE
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_0_TEMPLATE = Create__Instance__(m_Form_0_TEMPLATE);
				return m_Form_0_TEMPLATE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_0_TEMPLATE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_0_TEMPLATE);
				}
			}
		}

		public Form_1_LOGIN Form_1_LOGIN
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_1_LOGIN = Create__Instance__(m_Form_1_LOGIN);
				return m_Form_1_LOGIN;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_1_LOGIN)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_1_LOGIN);
				}
			}
		}

		public Form_2_ARTICLES Form_2_ARTICLES
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_2_ARTICLES = Create__Instance__(m_Form_2_ARTICLES);
				return m_Form_2_ARTICLES;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_2_ARTICLES)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_2_ARTICLES);
				}
			}
		}

		public Form_2_Familles Form_2_Familles
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_2_Familles = Create__Instance__(m_Form_2_Familles);
				return m_Form_2_Familles;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_2_Familles)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_2_Familles);
				}
			}
		}

		public Form_3_VENTE Form_3_VENTE
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_3_VENTE = Create__Instance__(m_Form_3_VENTE);
				return m_Form_3_VENTE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_3_VENTE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_3_VENTE);
				}
			}
		}

		public Form_3_VENTE_ENTETE Form_3_VENTE_ENTETE
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_3_VENTE_ENTETE = Create__Instance__(m_Form_3_VENTE_ENTETE);
				return m_Form_3_VENTE_ENTETE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_3_VENTE_ENTETE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_3_VENTE_ENTETE);
				}
			}
		}

		public Form_3_VENTE_JOURNAL Form_3_VENTE_JOURNAL
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_3_VENTE_JOURNAL = Create__Instance__(m_Form_3_VENTE_JOURNAL);
				return m_Form_3_VENTE_JOURNAL;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_3_VENTE_JOURNAL)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_3_VENTE_JOURNAL);
				}
			}
		}

		public Form_3_VENTE_MARGE Form_3_VENTE_MARGE
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_3_VENTE_MARGE = Create__Instance__(m_Form_3_VENTE_MARGE);
				return m_Form_3_VENTE_MARGE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_3_VENTE_MARGE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_3_VENTE_MARGE);
				}
			}
		}

		public Form_3_VENTE_RETOURS Form_3_VENTE_RETOURS
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_3_VENTE_RETOURS = Create__Instance__(m_Form_3_VENTE_RETOURS);
				return m_Form_3_VENTE_RETOURS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_3_VENTE_RETOURS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_3_VENTE_RETOURS);
				}
			}
		}

		public Form_5_CLIENTS Form_5_CLIENTS
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_5_CLIENTS = Create__Instance__(m_Form_5_CLIENTS);
				return m_Form_5_CLIENTS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_5_CLIENTS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_5_CLIENTS);
				}
			}
		}

		public Form_5_CLIENTS_ETAT_CREDITS Form_5_CLIENTS_ETAT_CREDITS
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_5_CLIENTS_ETAT_CREDITS = Create__Instance__(m_Form_5_CLIENTS_ETAT_CREDITS);
				return m_Form_5_CLIENTS_ETAT_CREDITS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_5_CLIENTS_ETAT_CREDITS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_5_CLIENTS_ETAT_CREDITS);
				}
			}
		}

		public Form_5_CLIENTS_HISTORIQUE_CREDIT_INITIAL Form_5_CLIENTS_HISTORIQUE_CREDIT_INITIAL
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_5_CLIENTS_HISTORIQUE_CREDIT_INITIAL = Create__Instance__(m_Form_5_CLIENTS_HISTORIQUE_CREDIT_INITIAL);
				return m_Form_5_CLIENTS_HISTORIQUE_CREDIT_INITIAL;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_5_CLIENTS_HISTORIQUE_CREDIT_INITIAL)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_5_CLIENTS_HISTORIQUE_CREDIT_INITIAL);
				}
			}
		}

		public Form_5_CLIENTS_LISTE Form_5_CLIENTS_LISTE
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_5_CLIENTS_LISTE = Create__Instance__(m_Form_5_CLIENTS_LISTE);
				return m_Form_5_CLIENTS_LISTE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_5_CLIENTS_LISTE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_5_CLIENTS_LISTE);
				}
			}
		}

		public Form_5_CLIENTS_MODIFICATION_CREDIT_INITIAL Form_5_CLIENTS_MODIFICATION_CREDIT_INITIAL
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_5_CLIENTS_MODIFICATION_CREDIT_INITIAL = Create__Instance__(m_Form_5_CLIENTS_MODIFICATION_CREDIT_INITIAL);
				return m_Form_5_CLIENTS_MODIFICATION_CREDIT_INITIAL;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_5_CLIENTS_MODIFICATION_CREDIT_INITIAL)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_5_CLIENTS_MODIFICATION_CREDIT_INITIAL);
				}
			}
		}

		public Form_5_CLIENTS_RDV Form_5_CLIENTS_RDV
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_5_CLIENTS_RDV = Create__Instance__(m_Form_5_CLIENTS_RDV);
				return m_Form_5_CLIENTS_RDV;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_5_CLIENTS_RDV)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_5_CLIENTS_RDV);
				}
			}
		}

		public Form_5_CLIENTS_REGLE Form_5_CLIENTS_REGLE
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_5_CLIENTS_REGLE = Create__Instance__(m_Form_5_CLIENTS_REGLE);
				return m_Form_5_CLIENTS_REGLE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_5_CLIENTS_REGLE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_5_CLIENTS_REGLE);
				}
			}
		}

		public Form_5_VENDEURS_LISTE Form_5_VENDEURS_LISTE
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_5_VENDEURS_LISTE = Create__Instance__(m_Form_5_VENDEURS_LISTE);
				return m_Form_5_VENDEURS_LISTE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_5_VENDEURS_LISTE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_5_VENDEURS_LISTE);
				}
			}
		}

		public Form_6_COMMANDES Form_6_COMMANDES
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_6_COMMANDES = Create__Instance__(m_Form_6_COMMANDES);
				return m_Form_6_COMMANDES;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_6_COMMANDES)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_6_COMMANDES);
				}
			}
		}

		public Form_6_DEPENSES Form_6_DEPENSES
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_6_DEPENSES = Create__Instance__(m_Form_6_DEPENSES);
				return m_Form_6_DEPENSES;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_6_DEPENSES)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_6_DEPENSES);
				}
			}
		}

		public Form_6_FOURNISSEURS Form_6_FOURNISSEURS
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_6_FOURNISSEURS = Create__Instance__(m_Form_6_FOURNISSEURS);
				return m_Form_6_FOURNISSEURS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_6_FOURNISSEURS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_6_FOURNISSEURS);
				}
			}
		}

		public Form_6_FOURNISSEURS_ETAT_CREDITS Form_6_FOURNISSEURS_ETAT_CREDITS
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_6_FOURNISSEURS_ETAT_CREDITS = Create__Instance__(m_Form_6_FOURNISSEURS_ETAT_CREDITS);
				return m_Form_6_FOURNISSEURS_ETAT_CREDITS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_6_FOURNISSEURS_ETAT_CREDITS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_6_FOURNISSEURS_ETAT_CREDITS);
				}
			}
		}

		public Form_6_FOURNISSEURS_HISTORIQUE_CREDIT_INITIAL Form_6_FOURNISSEURS_HISTORIQUE_CREDIT_INITIAL
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_6_FOURNISSEURS_HISTORIQUE_CREDIT_INITIAL = Create__Instance__(m_Form_6_FOURNISSEURS_HISTORIQUE_CREDIT_INITIAL);
				return m_Form_6_FOURNISSEURS_HISTORIQUE_CREDIT_INITIAL;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_6_FOURNISSEURS_HISTORIQUE_CREDIT_INITIAL)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_6_FOURNISSEURS_HISTORIQUE_CREDIT_INITIAL);
				}
			}
		}

		public Form_6_FOURNISSEURS_LISTE Form_6_FOURNISSEURS_LISTE
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_6_FOURNISSEURS_LISTE = Create__Instance__(m_Form_6_FOURNISSEURS_LISTE);
				return m_Form_6_FOURNISSEURS_LISTE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_6_FOURNISSEURS_LISTE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_6_FOURNISSEURS_LISTE);
				}
			}
		}

		public Form_6_FOURNISSEURS_MODIFICATION_CREDIT_INITIAL Form_6_FOURNISSEURS_MODIFICATION_CREDIT_INITIAL
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_6_FOURNISSEURS_MODIFICATION_CREDIT_INITIAL = Create__Instance__(m_Form_6_FOURNISSEURS_MODIFICATION_CREDIT_INITIAL);
				return m_Form_6_FOURNISSEURS_MODIFICATION_CREDIT_INITIAL;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_6_FOURNISSEURS_MODIFICATION_CREDIT_INITIAL)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_6_FOURNISSEURS_MODIFICATION_CREDIT_INITIAL);
				}
			}
		}

		public Form_6_FOURNISSEURS_REGLE Form_6_FOURNISSEURS_REGLE
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_6_FOURNISSEURS_REGLE = Create__Instance__(m_Form_6_FOURNISSEURS_REGLE);
				return m_Form_6_FOURNISSEURS_REGLE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_6_FOURNISSEURS_REGLE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_6_FOURNISSEURS_REGLE);
				}
			}
		}

		public Form_6_INVENTAIRES Form_6_INVENTAIRES
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_6_INVENTAIRES = Create__Instance__(m_Form_6_INVENTAIRES);
				return m_Form_6_INVENTAIRES;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_6_INVENTAIRES)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_6_INVENTAIRES);
				}
			}
		}

		public Form_6_MOUVEMENTS_STOCK Form_6_MOUVEMENTS_STOCK
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_6_MOUVEMENTS_STOCK = Create__Instance__(m_Form_6_MOUVEMENTS_STOCK);
				return m_Form_6_MOUVEMENTS_STOCK;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_6_MOUVEMENTS_STOCK)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_6_MOUVEMENTS_STOCK);
				}
			}
		}

		public Form_6_RECEPTIONS Form_6_RECEPTIONS
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_6_RECEPTIONS = Create__Instance__(m_Form_6_RECEPTIONS);
				return m_Form_6_RECEPTIONS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_6_RECEPTIONS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_6_RECEPTIONS);
				}
			}
		}

		public Form_6_SORTIES Form_6_SORTIES
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_6_SORTIES = Create__Instance__(m_Form_6_SORTIES);
				return m_Form_6_SORTIES;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_6_SORTIES)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_6_SORTIES);
				}
			}
		}

		public Form_8_gestion Form_8_gestion
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_8_gestion = Create__Instance__(m_Form_8_gestion);
				return m_Form_8_gestion;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_8_gestion)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_8_gestion);
				}
			}
		}

		public Form_90000_FACTURE Form_90000_FACTURE
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_90000_FACTURE = Create__Instance__(m_Form_90000_FACTURE);
				return m_Form_90000_FACTURE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_90000_FACTURE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_90000_FACTURE);
				}
			}
		}

		public Form_9000_BL Form_9000_BL
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_9000_BL = Create__Instance__(m_Form_9000_BL);
				return m_Form_9000_BL;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_9000_BL)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_9000_BL);
				}
			}
		}

		public Form_900_DEVIS Form_900_DEVIS
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_900_DEVIS = Create__Instance__(m_Form_900_DEVIS);
				return m_Form_900_DEVIS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_900_DEVIS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_900_DEVIS);
				}
			}
		}

		public Form_9_PARAMETRE Form_9_PARAMETRE
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_9_PARAMETRE = Create__Instance__(m_Form_9_PARAMETRE);
				return m_Form_9_PARAMETRE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_9_PARAMETRE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_9_PARAMETRE);
				}
			}
		}

		public Form_9_STATISTIQUES Form_9_STATISTIQUES
		{
			[DebuggerNonUserCode]
			get
			{
				m_Form_9_STATISTIQUES = Create__Instance__(m_Form_9_STATISTIQUES);
				return m_Form_9_STATISTIQUES;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Form_9_STATISTIQUES)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form_9_STATISTIQUES);
				}
			}
		}

		public FormDialog_1_UTILISATEURS FormDialog_1_UTILISATEURS
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_1_UTILISATEURS = Create__Instance__(m_FormDialog_1_UTILISATEURS);
				return m_FormDialog_1_UTILISATEURS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_1_UTILISATEURS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_1_UTILISATEURS);
				}
			}
		}

		public FormDialog_2_Configuration FormDialog_2_Configuration
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_2_Configuration = Create__Instance__(m_FormDialog_2_Configuration);
				return m_FormDialog_2_Configuration;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_2_Configuration)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_2_Configuration);
				}
			}
		}

		public FormDialog_3_Configuration_Suite FormDialog_3_Configuration_Suite
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_3_Configuration_Suite = Create__Instance__(m_FormDialog_3_Configuration_Suite);
				return m_FormDialog_3_Configuration_Suite;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_3_Configuration_Suite)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_3_Configuration_Suite);
				}
			}
		}

		public FormDialog_4_Configuration_Suite FormDialog_4_Configuration_Suite
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_4_Configuration_Suite = Create__Instance__(m_FormDialog_4_Configuration_Suite);
				return m_FormDialog_4_Configuration_Suite;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_4_Configuration_Suite)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_4_Configuration_Suite);
				}
			}
		}

		public FormDialog_5_MODE_P FormDialog_5_MODE_P
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_5_MODE_P = Create__Instance__(m_FormDialog_5_MODE_P);
				return m_FormDialog_5_MODE_P;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_5_MODE_P)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_5_MODE_P);
				}
			}
		}

		public FormDialog_8_BASE_DONNEE FormDialog_8_BASE_DONNEE
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_8_BASE_DONNEE = Create__Instance__(m_FormDialog_8_BASE_DONNEE);
				return m_FormDialog_8_BASE_DONNEE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_8_BASE_DONNEE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_8_BASE_DONNEE);
				}
			}
		}

		public FormDialog_acces_ADMIN FormDialog_acces_ADMIN
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_acces_ADMIN = Create__Instance__(m_FormDialog_acces_ADMIN);
				return m_FormDialog_acces_ADMIN;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_acces_ADMIN)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_acces_ADMIN);
				}
			}
		}

		public FormDialog_acces_MANAGER FormDialog_acces_MANAGER
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_acces_MANAGER = Create__Instance__(m_FormDialog_acces_MANAGER);
				return m_FormDialog_acces_MANAGER;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_acces_MANAGER)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_acces_MANAGER);
				}
			}
		}

		public FormDialog_AFFICHEUR_2 FormDialog_AFFICHEUR_2
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_AFFICHEUR_2 = Create__Instance__(m_FormDialog_AFFICHEUR_2);
				return m_FormDialog_AFFICHEUR_2;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_AFFICHEUR_2)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_AFFICHEUR_2);
				}
			}
		}

		public FormDialog_ALERT_ERREUR FormDialog_ALERT_ERREUR
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_ALERT_ERREUR = Create__Instance__(m_FormDialog_ALERT_ERREUR);
				return m_FormDialog_ALERT_ERREUR;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_ALERT_ERREUR)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_ALERT_ERREUR);
				}
			}
		}

		public FormDialog_ARTICLE_INCONNU FormDialog_ARTICLE_INCONNU
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_ARTICLE_INCONNU = Create__Instance__(m_FormDialog_ARTICLE_INCONNU);
				return m_FormDialog_ARTICLE_INCONNU;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_ARTICLE_INCONNU)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_ARTICLE_INCONNU);
				}
			}
		}

		public FormDialog_ATTENTES FormDialog_ATTENTES
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_ATTENTES = Create__Instance__(m_FormDialog_ATTENTES);
				return m_FormDialog_ATTENTES;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_ATTENTES)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_ATTENTES);
				}
			}
		}

		public FormDialog_ATTRIBUTIONS FormDialog_ATTRIBUTIONS
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_ATTRIBUTIONS = Create__Instance__(m_FormDialog_ATTRIBUTIONS);
				return m_FormDialog_ATTRIBUTIONS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_ATTRIBUTIONS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_ATTRIBUTIONS);
				}
			}
		}

		public FormDialog_BLOC_NOTE FormDialog_BLOC_NOTE
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_BLOC_NOTE = Create__Instance__(m_FormDialog_BLOC_NOTE);
				return m_FormDialog_BLOC_NOTE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_BLOC_NOTE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_BLOC_NOTE);
				}
			}
		}

		public FormDialog_calc FormDialog_calc
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_calc = Create__Instance__(m_FormDialog_calc);
				return m_FormDialog_calc;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_calc)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_calc);
				}
			}
		}

		public FormDialog_CLAVIER FormDialog_CLAVIER
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_CLAVIER = Create__Instance__(m_FormDialog_CLAVIER);
				return m_FormDialog_CLAVIER;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_CLAVIER)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_CLAVIER);
				}
			}
		}

		public FormDialog_CLOTURE FormDialog_CLOTURE
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_CLOTURE = Create__Instance__(m_FormDialog_CLOTURE);
				return m_FormDialog_CLOTURE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_CLOTURE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_CLOTURE);
				}
			}
		}

		public FormDialog_COMPTER_CAISSE FormDialog_COMPTER_CAISSE
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_COMPTER_CAISSE = Create__Instance__(m_FormDialog_COMPTER_CAISSE);
				return m_FormDialog_COMPTER_CAISSE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_COMPTER_CAISSE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_COMPTER_CAISSE);
				}
			}
		}

		public FormDialog_DIVERS FormDialog_DIVERS
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_DIVERS = Create__Instance__(m_FormDialog_DIVERS);
				return m_FormDialog_DIVERS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_DIVERS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_DIVERS);
				}
			}
		}

		public FormDialog_DUPLICATA FormDialog_DUPLICATA
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_DUPLICATA = Create__Instance__(m_FormDialog_DUPLICATA);
				return m_FormDialog_DUPLICATA;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_DUPLICATA)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_DUPLICATA);
				}
			}
		}

		public FormDialog_ETAT_ALERTES_STOCK FormDialog_ETAT_ALERTES_STOCK
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_ETAT_ALERTES_STOCK = Create__Instance__(m_FormDialog_ETAT_ALERTES_STOCK);
				return m_FormDialog_ETAT_ALERTES_STOCK;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_ETAT_ALERTES_STOCK)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_ETAT_ALERTES_STOCK);
				}
			}
		}

		public FormDialog_ETAT_ALERTS_PEREMPTION FormDialog_ETAT_ALERTS_PEREMPTION
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_ETAT_ALERTS_PEREMPTION = Create__Instance__(m_FormDialog_ETAT_ALERTS_PEREMPTION);
				return m_FormDialog_ETAT_ALERTS_PEREMPTION;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_ETAT_ALERTS_PEREMPTION)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_ETAT_ALERTS_PEREMPTION);
				}
			}
		}

		public FormDialog_ETAT_INVENTAIRE FormDialog_ETAT_INVENTAIRE
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_ETAT_INVENTAIRE = Create__Instance__(m_FormDialog_ETAT_INVENTAIRE);
				return m_FormDialog_ETAT_INVENTAIRE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_ETAT_INVENTAIRE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_ETAT_INVENTAIRE);
				}
			}
		}

		public FormDialog_ETAT_LISTE_ARTICLES FormDialog_ETAT_LISTE_ARTICLES
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_ETAT_LISTE_ARTICLES = Create__Instance__(m_FormDialog_ETAT_LISTE_ARTICLES);
				return m_FormDialog_ETAT_LISTE_ARTICLES;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_ETAT_LISTE_ARTICLES)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_ETAT_LISTE_ARTICLES);
				}
			}
		}

		public FormDialog_ETAT_STOCK FormDialog_ETAT_STOCK
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_ETAT_STOCK = Create__Instance__(m_FormDialog_ETAT_STOCK);
				return m_FormDialog_ETAT_STOCK;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_ETAT_STOCK)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_ETAT_STOCK);
				}
			}
		}

		public FormDialog_ETIQUETTE_AUTOC FormDialog_ETIQUETTE_AUTOC
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_ETIQUETTE_AUTOC = Create__Instance__(m_FormDialog_ETIQUETTE_AUTOC);
				return m_FormDialog_ETIQUETTE_AUTOC;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_ETIQUETTE_AUTOC)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_ETIQUETTE_AUTOC);
				}
			}
		}

		public FormDialog_ETIQUETTE_AUTOC_A4 FormDialog_ETIQUETTE_AUTOC_A4
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_ETIQUETTE_AUTOC_A4 = Create__Instance__(m_FormDialog_ETIQUETTE_AUTOC_A4);
				return m_FormDialog_ETIQUETTE_AUTOC_A4;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_ETIQUETTE_AUTOC_A4)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_ETIQUETTE_AUTOC_A4);
				}
			}
		}

		public FormDialog_FONDS_CAISSE FormDialog_FONDS_CAISSE
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_FONDS_CAISSE = Create__Instance__(m_FormDialog_FONDS_CAISSE);
				return m_FormDialog_FONDS_CAISSE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_FONDS_CAISSE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_FONDS_CAISSE);
				}
			}
		}

		public FormDialog_google FormDialog_google
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_google = Create__Instance__(m_FormDialog_google);
				return m_FormDialog_google;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_google)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_google);
				}
			}
		}

		public FormDialog_IMPORTER_ARTICLES FormDialog_IMPORTER_ARTICLES
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_IMPORTER_ARTICLES = Create__Instance__(m_FormDialog_IMPORTER_ARTICLES);
				return m_FormDialog_IMPORTER_ARTICLES;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_IMPORTER_ARTICLES)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_IMPORTER_ARTICLES);
				}
			}
		}

		public FormDialog_info FormDialog_info
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_info = Create__Instance__(m_FormDialog_info);
				return m_FormDialog_info;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_info)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_info);
				}
			}
		}

		public FormDialog_LISTE_COULEURS FormDialog_LISTE_COULEURS
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_LISTE_COULEURS = Create__Instance__(m_FormDialog_LISTE_COULEURS);
				return m_FormDialog_LISTE_COULEURS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_LISTE_COULEURS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_LISTE_COULEURS);
				}
			}
		}

		public FormDialog_LISTE_TAILLES FormDialog_LISTE_TAILLES
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_LISTE_TAILLES = Create__Instance__(m_FormDialog_LISTE_TAILLES);
				return m_FormDialog_LISTE_TAILLES;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_LISTE_TAILLES)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_LISTE_TAILLES);
				}
			}
		}

		public FormDialog_MODE_P FormDialog_MODE_P
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_MODE_P = Create__Instance__(m_FormDialog_MODE_P);
				return m_FormDialog_MODE_P;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_MODE_P)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_MODE_P);
				}
			}
		}

		public FormDialog_MODIFICATION_PRIX FormDialog_MODIFICATION_PRIX
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_MODIFICATION_PRIX = Create__Instance__(m_FormDialog_MODIFICATION_PRIX);
				return m_FormDialog_MODIFICATION_PRIX;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_MODIFICATION_PRIX)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_MODIFICATION_PRIX);
				}
			}
		}

		public FormDialog_MODIFICATION_QTE FormDialog_MODIFICATION_QTE
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_MODIFICATION_QTE = Create__Instance__(m_FormDialog_MODIFICATION_QTE);
				return m_FormDialog_MODIFICATION_QTE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_MODIFICATION_QTE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_MODIFICATION_QTE);
				}
			}
		}

		public FormDialog_MSGBOX_OK FormDialog_MSGBOX_OK
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_MSGBOX_OK = Create__Instance__(m_FormDialog_MSGBOX_OK);
				return m_FormDialog_MSGBOX_OK;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_MSGBOX_OK)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_MSGBOX_OK);
				}
			}
		}

		public FormDialog_MSGBOX_YES_NO FormDialog_MSGBOX_YES_NO
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_MSGBOX_YES_NO = Create__Instance__(m_FormDialog_MSGBOX_YES_NO);
				return m_FormDialog_MSGBOX_YES_NO;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_MSGBOX_YES_NO)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_MSGBOX_YES_NO);
				}
			}
		}

		public FormDialog_PATIENTER FormDialog_PATIENTER
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_PATIENTER = Create__Instance__(m_FormDialog_PATIENTER);
				return m_FormDialog_PATIENTER;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_PATIENTER)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_PATIENTER);
				}
			}
		}

		public FormDialog_PATIENTER_BALANCE FormDialog_PATIENTER_BALANCE
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_PATIENTER_BALANCE = Create__Instance__(m_FormDialog_PATIENTER_BALANCE);
				return m_FormDialog_PATIENTER_BALANCE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_PATIENTER_BALANCE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_PATIENTER_BALANCE);
				}
			}
		}

		public FormDialog_PESEE_BALANCE FormDialog_PESEE_BALANCE
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_PESEE_BALANCE = Create__Instance__(m_FormDialog_PESEE_BALANCE);
				return m_FormDialog_PESEE_BALANCE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_PESEE_BALANCE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_PESEE_BALANCE);
				}
			}
		}

		public FormDialog_PRIX_LIBRE FormDialog_PRIX_LIBRE
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_PRIX_LIBRE = Create__Instance__(m_FormDialog_PRIX_LIBRE);
				return m_FormDialog_PRIX_LIBRE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_PRIX_LIBRE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_PRIX_LIBRE);
				}
			}
		}

		public FormDialog_QUANTITE FormDialog_QUANTITE
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_QUANTITE = Create__Instance__(m_FormDialog_QUANTITE);
				return m_FormDialog_QUANTITE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_QUANTITE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_QUANTITE);
				}
			}
		}

		public FormDialog_QUITTER FormDialog_QUITTER
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_QUITTER = Create__Instance__(m_FormDialog_QUITTER);
				return m_FormDialog_QUITTER;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_QUITTER)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_QUITTER);
				}
			}
		}

		public FormDialog_RACCOURCIES FormDialog_RACCOURCIES
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_RACCOURCIES = Create__Instance__(m_FormDialog_RACCOURCIES);
				return m_FormDialog_RACCOURCIES;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_RACCOURCIES)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_RACCOURCIES);
				}
			}
		}

		public FormDialog_RAPPORT FormDialog_RAPPORT
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_RAPPORT = Create__Instance__(m_FormDialog_RAPPORT);
				return m_FormDialog_RAPPORT;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_RAPPORT)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_RAPPORT);
				}
			}
		}

		public FormDialog_REMISE FormDialog_REMISE
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_REMISE = Create__Instance__(m_FormDialog_REMISE);
				return m_FormDialog_REMISE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_REMISE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_REMISE);
				}
			}
		}

		public FormDialog_RETOUR FormDialog_RETOUR
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_RETOUR = Create__Instance__(m_FormDialog_RETOUR);
				return m_FormDialog_RETOUR;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_RETOUR)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_RETOUR);
				}
			}
		}

		public FormDialog_RFID FormDialog_RFID
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_RFID = Create__Instance__(m_FormDialog_RFID);
				return m_FormDialog_RFID;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_RFID)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_RFID);
				}
			}
		}

		public FormDialog_ROBOT FormDialog_ROBOT
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_ROBOT = Create__Instance__(m_FormDialog_ROBOT);
				return m_FormDialog_ROBOT;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_ROBOT)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_ROBOT);
				}
			}
		}

		public FormDialog_THEME FormDialog_THEME
		{
			[DebuggerNonUserCode]
			get
			{
				m_FormDialog_THEME = Create__Instance__(m_FormDialog_THEME);
				return m_FormDialog_THEME;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_FormDialog_THEME)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FormDialog_THEME);
				}
			}
		}

		public JOURNAL_REGELEMENTS JOURNAL_REGELEMENTS
		{
			[DebuggerNonUserCode]
			get
			{
				m_JOURNAL_REGELEMENTS = Create__Instance__(m_JOURNAL_REGELEMENTS);
				return m_JOURNAL_REGELEMENTS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_JOURNAL_REGELEMENTS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_JOURNAL_REGELEMENTS);
				}
			}
		}

		public Report_BC Report_BC
		{
			[DebuggerNonUserCode]
			get
			{
				m_Report_BC = Create__Instance__(m_Report_BC);
				return m_Report_BC;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Report_BC)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Report_BC);
				}
			}
		}

		public Report_BL Report_BL
		{
			[DebuggerNonUserCode]
			get
			{
				m_Report_BL = Create__Instance__(m_Report_BL);
				return m_Report_BL;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Report_BL)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Report_BL);
				}
			}
		}

		public Report_BR Report_BR
		{
			[DebuggerNonUserCode]
			get
			{
				m_Report_BR = Create__Instance__(m_Report_BR);
				return m_Report_BR;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Report_BR)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Report_BR);
				}
			}
		}

		public Report_BS Report_BS
		{
			[DebuggerNonUserCode]
			get
			{
				m_Report_BS = Create__Instance__(m_Report_BS);
				return m_Report_BS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Report_BS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Report_BS);
				}
			}
		}

		public Report_CLIENTS_ETAT_CREDITS Report_CLIENTS_ETAT_CREDITS
		{
			[DebuggerNonUserCode]
			get
			{
				m_Report_CLIENTS_ETAT_CREDITS = Create__Instance__(m_Report_CLIENTS_ETAT_CREDITS);
				return m_Report_CLIENTS_ETAT_CREDITS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Report_CLIENTS_ETAT_CREDITS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Report_CLIENTS_ETAT_CREDITS);
				}
			}
		}

		public Report_CLIENTS_ETAT_HISTORIQUE Report_CLIENTS_ETAT_HISTORIQUE
		{
			[DebuggerNonUserCode]
			get
			{
				m_Report_CLIENTS_ETAT_HISTORIQUE = Create__Instance__(m_Report_CLIENTS_ETAT_HISTORIQUE);
				return m_Report_CLIENTS_ETAT_HISTORIQUE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Report_CLIENTS_ETAT_HISTORIQUE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Report_CLIENTS_ETAT_HISTORIQUE);
				}
			}
		}

		public Report_CLIENTS_ETAT_HISTORIQUE_DETAILS Report_CLIENTS_ETAT_HISTORIQUE_DETAILS
		{
			[DebuggerNonUserCode]
			get
			{
				m_Report_CLIENTS_ETAT_HISTORIQUE_DETAILS = Create__Instance__(m_Report_CLIENTS_ETAT_HISTORIQUE_DETAILS);
				return m_Report_CLIENTS_ETAT_HISTORIQUE_DETAILS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Report_CLIENTS_ETAT_HISTORIQUE_DETAILS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Report_CLIENTS_ETAT_HISTORIQUE_DETAILS);
				}
			}
		}

		public Report_DEVIS Report_DEVIS
		{
			[DebuggerNonUserCode]
			get
			{
				m_Report_DEVIS = Create__Instance__(m_Report_DEVIS);
				return m_Report_DEVIS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Report_DEVIS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Report_DEVIS);
				}
			}
		}

		public Report_ETAT_STOCK Report_ETAT_STOCK
		{
			[DebuggerNonUserCode]
			get
			{
				m_Report_ETAT_STOCK = Create__Instance__(m_Report_ETAT_STOCK);
				return m_Report_ETAT_STOCK;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Report_ETAT_STOCK)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Report_ETAT_STOCK);
				}
			}
		}

		public Report_FACTURE Report_FACTURE
		{
			[DebuggerNonUserCode]
			get
			{
				m_Report_FACTURE = Create__Instance__(m_Report_FACTURE);
				return m_Report_FACTURE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Report_FACTURE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Report_FACTURE);
				}
			}
		}

		public Report_FOURNISSEURS_ETAT_CREDITS Report_FOURNISSEURS_ETAT_CREDITS
		{
			[DebuggerNonUserCode]
			get
			{
				m_Report_FOURNISSEURS_ETAT_CREDITS = Create__Instance__(m_Report_FOURNISSEURS_ETAT_CREDITS);
				return m_Report_FOURNISSEURS_ETAT_CREDITS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Report_FOURNISSEURS_ETAT_CREDITS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Report_FOURNISSEURS_ETAT_CREDITS);
				}
			}
		}

		public Report_FOURNISSEURS_ETAT_HISTORIQUE Report_FOURNISSEURS_ETAT_HISTORIQUE
		{
			[DebuggerNonUserCode]
			get
			{
				m_Report_FOURNISSEURS_ETAT_HISTORIQUE = Create__Instance__(m_Report_FOURNISSEURS_ETAT_HISTORIQUE);
				return m_Report_FOURNISSEURS_ETAT_HISTORIQUE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Report_FOURNISSEURS_ETAT_HISTORIQUE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Report_FOURNISSEURS_ETAT_HISTORIQUE);
				}
			}
		}

		public Report_FOURNISSEURS_ETAT_HISTORIQUE_DETAILS Report_FOURNISSEURS_ETAT_HISTORIQUE_DETAILS
		{
			[DebuggerNonUserCode]
			get
			{
				m_Report_FOURNISSEURS_ETAT_HISTORIQUE_DETAILS = Create__Instance__(m_Report_FOURNISSEURS_ETAT_HISTORIQUE_DETAILS);
				return m_Report_FOURNISSEURS_ETAT_HISTORIQUE_DETAILS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Report_FOURNISSEURS_ETAT_HISTORIQUE_DETAILS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Report_FOURNISSEURS_ETAT_HISTORIQUE_DETAILS);
				}
			}
		}

		public Report_INVENTAIRE Report_INVENTAIRE
		{
			[DebuggerNonUserCode]
			get
			{
				m_Report_INVENTAIRE = Create__Instance__(m_Report_INVENTAIRE);
				return m_Report_INVENTAIRE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Report_INVENTAIRE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Report_INVENTAIRE);
				}
			}
		}

		public Report_NOMENCLATURE Report_NOMENCLATURE
		{
			[DebuggerNonUserCode]
			get
			{
				m_Report_NOMENCLATURE = Create__Instance__(m_Report_NOMENCLATURE);
				return m_Report_NOMENCLATURE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Report_NOMENCLATURE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Report_NOMENCLATURE);
				}
			}
		}

		public Report_PEREMPTIONS Report_PEREMPTIONS
		{
			[DebuggerNonUserCode]
			get
			{
				m_Report_PEREMPTIONS = Create__Instance__(m_Report_PEREMPTIONS);
				return m_Report_PEREMPTIONS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Report_PEREMPTIONS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Report_PEREMPTIONS);
				}
			}
		}

		public Report_RAPPORT_IMPRESSION Report_RAPPORT_IMPRESSION
		{
			[DebuggerNonUserCode]
			get
			{
				m_Report_RAPPORT_IMPRESSION = Create__Instance__(m_Report_RAPPORT_IMPRESSION);
				return m_Report_RAPPORT_IMPRESSION;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Report_RAPPORT_IMPRESSION)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Report_RAPPORT_IMPRESSION);
				}
			}
		}

		public Report_TICKET_80_ARABE Report_TICKET_80_ARABE
		{
			[DebuggerNonUserCode]
			get
			{
				m_Report_TICKET_80_ARABE = Create__Instance__(m_Report_TICKET_80_ARABE);
				return m_Report_TICKET_80_ARABE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Report_TICKET_80_ARABE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Report_TICKET_80_ARABE);
				}
			}
		}

		public Report_TICKET_A4 Report_TICKET_A4
		{
			[DebuggerNonUserCode]
			get
			{
				m_Report_TICKET_A4 = Create__Instance__(m_Report_TICKET_A4);
				return m_Report_TICKET_A4;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Report_TICKET_A4)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Report_TICKET_A4);
				}
			}
		}

		public Report_TICKET_A5 Report_TICKET_A5
		{
			[DebuggerNonUserCode]
			get
			{
				m_Report_TICKET_A5 = Create__Instance__(m_Report_TICKET_A5);
				return m_Report_TICKET_A5;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Report_TICKET_A5)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Report_TICKET_A5);
				}
			}
		}

		public Report_TICKET_A5_ARABE Report_TICKET_A5_ARABE
		{
			[DebuggerNonUserCode]
			get
			{
				m_Report_TICKET_A5_ARABE = Create__Instance__(m_Report_TICKET_A5_ARABE);
				return m_Report_TICKET_A5_ARABE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_Report_TICKET_A5_ARABE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Report_TICKET_A5_ARABE);
				}
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			if (Instance == null || (((Control)Instance).IsDisposed ? true : false))
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(T), null);
				try
				{
					return new T();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError(ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message);
					throw new InvalidOperationException(resourceString, ex.InnerException);
				}
				finally
				{
					m_FormBeingCreated.Remove(typeof(T));
				}
			}
			return Instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			((Component)instance/*cast due to constrained. prefix*/).Dispose();
			instance = default;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public MyForms()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return typeof(MyForms);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class MyWebServices
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return typeof(MyWebServices);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance)
		{
			instance = default;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public MyWebServices()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T m_ThreadStaticValue;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new T();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public ThreadSafeObjectProvider()
		{
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

	private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static MyForms Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
