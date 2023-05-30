//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SmartSchool.DAL.Entities
//{
//	public class StripeEntities
//	{
//	}

//	public record CreateCardResource(
//		string Name,
//		string Number,
//		string ExpiryYear,
//		string ExpiryMonth,
//		string Cvc
//	);
//	public record CustomerCharge(
//		string Name,
//		string Email,
//		long Amount,
//		string Description,
//		CreateCardResource Card
//	);
//	public record CreateCustomerResource(
//		string Email,
//		string Name,
//		CreateCardResource Card
//	);
//	public record CustomerResource(
//		string CustomerId,
//		string Email,
//		string Name
//	);
//	public record CreateChargeResource(
//		string Currency,
//		long Amount,
//		string CustomerId,
//		string ReceiptEmail,
//		string Description
//	);
//	public record ChargeResource(
//		string ChargeId,
//		string Currency,
//		long Amount,
//		string CustomerId,
//		string ReceiptEmail,
//		string Description
//	);

//}
