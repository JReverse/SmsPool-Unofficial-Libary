## DOCS
```csharp

//init client
SMSClient client = new SMSClient("API_KEY");
 
 //order
 await client.Order("POOL", "SERVICE", "COUNTRYCODE");
 
 //order example
 SMSClient client = new SMSClient("API_KEY");
 var order_id = await client.Order("3", "Snapchat", "RU");
 
  //check
 await client.Check("ORDER_ID");
 
 //check example
 SMSClient client = new SMSClient("API_KEY");
 var order_id = await client.Order("3", "Snapchat", "RU");
 var smscode = await client.Check(order_id); // Will return Waiting if still waiting it auto refund if expired
 
 //cancel
 await client.Cancel("ORDER_ID");
 
  //cancel example
 SMSClient client = new SMSClient("API_KEY");
 var order_id = await client.Order("3", "Snapchat", "RU");
 await client.Cancel(order_id); // Cancels sms # must be over 2 mins


```

## SMSPOOL
+ https://smspool.net/
