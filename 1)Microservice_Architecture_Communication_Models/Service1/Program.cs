//HTTP protokoliünden bağlanıyorsa servisler senkrondur.


HttpClient httpclient = new HttpClient();
HttpResponseMessage respose = await httpclient.GetAsync("https://localhost:7052/api/values");
if (respose.IsSuccessStatusCode)
{
    Console.WriteLine( await respose.Content.ReadAsStringAsync());
}