using System;
using System.Collections.Generic;

namespace IUGU.Web.Models
{
    public class Pix
    {
        public string qrcode { get; set; }
        public string qrcode_text { get; set; }
        public string status { get; set; }
    }

    public class ItemResponse
    {
        public string id { get; set; }
        public string description { get; set; }
        public int price_cents { get; set; }
        public int quantity { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string price { get; set; }
    }

    public class Variable
    {
        public string variable { get; set; }
        public string value { get; set; }
    }

    public class Log
    {
        public string id { get; set; }
        public string description { get; set; }
        public string notes { get; set; }
        public string created_at { get; set; }
    }

    public class IUGUResponse
    {
        public string id { get; set; }
        public string due_date { get; set; }
        public string currency { get; set; }
        public object discount_cents { get; set; }
        public string email { get; set; }
        public int items_total_cents { get; set; }
        public object notification_url { get; set; }
        public object return_url { get; set; }
        public string status { get; set; }
        public object tax_cents { get; set; }
        public int total_cents { get; set; }
        public int total_paid_cents { get; set; }
        public object taxes_paid_cents { get; set; }
        public object paid_at { get; set; }
        public object paid_cents { get; set; }
        public object cc_emails { get; set; }
        public object financial_return_date { get; set; }
        public string payable_with { get; set; }
        public object overpaid_cents { get; set; }
        public object ignore_due_email { get; set; }
        public object ignore_canceled_email { get; set; }
        public object advance_fee_cents { get; set; }
        public object commission_cents { get; set; }
        public bool early_payment_discount { get; set; }
        public object order_id { get; set; }
        public DateTime updated_at { get; set; }
        public object credit_card_brand { get; set; }
        public object credit_card_bin { get; set; }
        public object credit_card_last_4 { get; set; }
        public object credit_card_captured_at { get; set; }
        public object credit_card_tid { get; set; }
        public object external_reference { get; set; }
        public object max_installments_value { get; set; }
        public string payer_name { get; set; }
        public object payer_email { get; set; }
        public string payer_cpf_cnpj { get; set; }
        public object payer_phone { get; set; }
        public object payer_phone_prefix { get; set; }
        public object payer_address_zip_code { get; set; }
        public object payer_address_street { get; set; }
        public object payer_address_district { get; set; }
        public object payer_address_city { get; set; }
        public object payer_address_state { get; set; }
        public object payer_address_number { get; set; }
        public object payer_address_complement { get; set; }
        public object payer_address_country { get; set; }
        public int late_payment_fine { get; set; }
        public string secure_id { get; set; }
        public string secure_url { get; set; }
        public object customer_id { get; set; }
        public object customer_ref { get; set; }
        public object customer_name { get; set; }
        public object user_id { get; set; }
        public string total { get; set; }
        public string taxes_paid { get; set; }
        public string total_paid { get; set; }
        public string total_overpaid { get; set; }
        public string total_refunded { get; set; }
        public string commission { get; set; }
        public string fines_on_occurrence_day { get; set; }
        public string total_on_occurrence_day { get; set; }
        public int fines_on_occurrence_day_cents { get; set; }
        public int total_on_occurrence_day_cents { get; set; }
        public int refunded_cents { get; set; }
        public int remaining_captured_cents { get; set; }
        public object advance_fee { get; set; }
        public string paid { get; set; }
        public object original_payment_id { get; set; }
        public object double_payment_id { get; set; }
        public bool per_day_interest { get; set; }
        public object per_day_interest_value { get; set; }
        public object interest { get; set; }
        public object discount { get; set; }
        public object duplicated_invoice_id { get; set; }
        public string created_at { get; set; }
        public DateTime created_at_iso { get; set; }
        public object authorized_at { get; set; }
        public object authorized_at_iso { get; set; }
        public object expired_at { get; set; }
        public object expired_at_iso { get; set; }
        public object refunded_at { get; set; }
        public object refunded_at_iso { get; set; }
        public object canceled_at { get; set; }
        public object canceled_at_iso { get; set; }
        public object protested_at { get; set; }
        public object protested_at_iso { get; set; }
        public object chargeback_at { get; set; }
        public object chargeback_at_iso { get; set; }
        public object occurrence_date { get; set; }
        public object refundable { get; set; }
        public object installments { get; set; }
        public int? transaction_number { get; set; }
        public object payment_method { get; set; }
        public object financial_return_dates { get; set; }
        public object bank_slip { get; set; }
        public Pix pix { get; set; }
        public List<ItemResponse> items { get; set; }
        public List<object> early_payment_discounts { get; set; }
        public List<Variable> variables { get; set; }
        public List<object> custom_variables { get; set; }
        public List<Log> logs { get; set; }
        public object credit_card_transaction { get; set; }
    }


}
