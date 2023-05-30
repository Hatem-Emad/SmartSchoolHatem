//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using SmartSchool.BL.Services;
//using SmartSchool.DAL.Entities;
//using Stripe;
//using Newtonsoft.Json;

//namespace SmartSchool.Api.Controllers
//{
//	[Route("api/[controller]")]
//	[ApiController]
//	public class StripeController : ControllerBase
//	{
//		private readonly IStripeService _stripeService;

//		public StripeController(IStripeService stripeService)
//		{
//			_stripeService = stripeService;
//		}

//		[HttpPost("customercharge")]
//		public async Task<ActionResult<ChargeResource>> CustomerCharge([FromBody] CustomerCharge resource)
//		{
//			var response = await _stripeService.CreateCustomerCharge(resource);

//			return Ok(response);
//		}

//		[HttpPost("customer")]
//		public async Task<ActionResult<CustomerResource>> CreateCustomer([FromBody] CreateCustomerResource resource, CancellationToken cancellationToken)
//		{
//			var response = await _stripeService.CreateCustomer(resource, cancellationToken);

//			return Ok(response);
//		}

//		[HttpPost("charge")]
//		public async Task<ActionResult<ChargeResource>> CreateCharge([FromBody] CreateChargeResource resource, CancellationToken cancellationToken)
//		{
//			var response = await _stripeService.CreateCharge(resource, cancellationToken);
//			return Ok(response);
//		}

//		[HttpPost("paymentlink")]
//		//public JsonResult CreatePaymentLink()
//		public ActionResult CreatePaymentLink()
//		{

//			var options = new PaymentLinkCreateOptions
//			{
//				LineItems = new List<PaymentLinkLineItemOptions>
//				{
//				  new PaymentLinkLineItemOptions
//				  {
//					//Price = "price_1ND6wwAKIAWYd9h1DCQIegks",
//					Price = "price_1NDU3QAKIAWYd9h1hNyGag55",
//					Quantity = 1,
//				  },
//				},
//			};
//			var service = new PaymentLinkService();
//			var paymentLink = service.Create(options);
//			return Ok(paymentLink.Url);
//			//var json = JsonConvert.SerializeObject(paymentLink);

//			//return Json(json);
//			// Return the PaymentLink to the user.
//			//return Json(paymentLink, JsonRequestBehavior.AllowGet);
//			//return Json(paymentLink);

//		}
//		//public class WebhookController : Controller

//			//dh copy paste
//		//[HttpPost]
//		//public async Task<IActionResult> Index()
//		//{
//		//	// This is your Stripe CLI webhook secret for testing your endpoint locally.
//		//	const string endpointSecret = "whsec_ba1e1a37547d431c582da3207619aa1113d6c8d3eb90914fb7f988f2c7eb9408";
//		//	var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();
//		//	try
//		//	{
//		//		//didnot work, null ref
//		//		var stripeEvent = EventUtility.ConstructEvent(json,Request.Headers["Stripe-Signature"], endpointSecret);

//		//		// Handle the event
//		//		if (stripeEvent.Type == Events.PaymentIntentSucceeded)
//		//		{
//		//		}
//		//		// ... handle other event types
//		//		else
//		//		{
//		//			Console.WriteLine("Unhandled event type: {0}", stripeEvent.Type);
//		//		}

//		//		return Ok();
//		//	}
//		//	catch (StripeException e)
//		//	{
//		//		return BadRequest(e);
//		//	}
//		//}
		
		
		
//		//public ActionResult HandleWebhook(StripeWebhookContext context)
//		//{
//		//	// Get the payment ID from the webhook data.
//		//	string paymentId = context.Data.Object.Id;

//		//	// Get the payment status from Stripe.
//		//	var payment = Stripe.Payment.retrieve(paymentId);

//		//	// Check the payment status.
//		//	if (payment.Status == "succeeded")
//		//	{
//		//		// Update the database and send the customer a confirmation message.
//		//	}
//		//	else
//		//	{
//		//		// Handle the error.
//		//	}

//		//	return Json(new { success = true });
//		//}



//	}
//}
