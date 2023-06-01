using Newtonsoft.Json;
namespace AuraSDK{
    public class LCDTransactionList{
            public class Transaction{
                public class Body{
                    public class Message{
                        public class Amount{
                            public string denom;
                            public string amount;
                        }
                        [JsonProperty(PropertyName = "@type")]
                        public string type;
                        [JsonProperty(PropertyName = "from_address")]
                        public string fromAddress;
                        [JsonProperty(PropertyName = "to_address")]
                        public string toAddress;
                        [JsonProperty(PropertyName = "amount")]
                        public Amount[] amount;
                    }
                    [JsonProperty(PropertyName = "messages")]
                    public Message[] messages;
                }
                [JsonProperty(PropertyName = "body")]
                public Body body;
            }
            [JsonProperty(PropertyName = "txs")]
            public Transaction[] transactions;
            public class TransactionResponse{
                [JsonProperty(PropertyName = "txHash")]
                public string hash;
                [JsonProperty(PropertyName = "timestamp")]
                public string timestamp;
            }
            [JsonProperty(PropertyName = "tx_responses")]
            public TransactionResponse[] transactionResponses;
        }
    public enum TransactionType{
        SEND,
        RECEIVE
    }
    public class AuraTransaction{
        public string fromAddress;
        public string toAddress;
        public string amount;
        public string timestamp;
        public TransactionType type;
    }
}