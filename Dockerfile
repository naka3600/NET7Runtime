# .NET 7 SDKをベースにする
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

# ソースコードをコピーする
COPY ./ResidentApp .

# ビルドする
RUN dotnet publish -c Release -o out

# 実行するためのランタイムイメージを作成する
FROM mcr.microsoft.com/dotnet/runtime:7.0

RUN apt-get update && apt-get install -y procps

WORKDIR /app
COPY --from=build /app/out .

# 実行する
CMD ["dotnet", "ResidentApp.dll"]

