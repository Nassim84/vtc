# 🚗 Mon Backend VTC (Uber Clone)

Ce projet est un backend léger en ASP.NET Core permettant de recevoir des demandes de devis VTC et d'envoyer un email contenant les détails.

## 🔧 Tech Stack

- ASP.NET Core
- SMTP (via Gmail)
- REST API
- CORS
- Aucune base de données

---

## 🚀 Fonctionnalités

- ✅ Envoi d'un email structuré à un destinataire préconfiguré
- ✅ CORS activé pour le frontend (React ou autre)
- ✅ Variables d’environnement pour la sécurité (SMTP)

---

## ⚙️ Configuration requise

Créer les variables d'environnement suivantes :

| Nom            | Description                       |
| -------------- | --------------------------------- |
| SMTP_HOST      | Adresse SMTP (ex: smtp.gmail.com) |
| SMTP_PORT      | Port SMTP (ex: 587)               |
| SMTP_USER      | Adresse email de l’expéditeur     |
| SMTP_PASSWORD  | Mot de passe d’application        |
| SMTP_RECIPIENT | Adresse de réception du devis     |

---

## 📬 Endpoint API

`POST /api/devis`

Body JSON :

```json
{
	"nom": "Jean Dupont",
	"email": "jean@example.com",
	"telephone": "0600000000",
	"depart": "Paris",
	"arrivee": "Lyon",
	"dateHeure": "2025-06-10T15:30:00",
	"message": "Besoin d’un siège bébé"
}
```
