import yfinance as yf

msft = yf.Ticker("MSFT")
print(msft)

print(msft.info)

msft.history(period="max")
