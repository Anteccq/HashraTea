# HashraTea
> A simple hash checker

ファイルのハッシュ値を求めるアプリケーションです。  
hTea.exe が置かれているフォルダまでのパスを通して下さい。  
自己完結型アプリケーションのため、実行時にランタイムは必要ありません。  
SHA256 と MD5 に対応しています。

## Quick Start
```
$ hTea -sha256 filename
e3bebea8a1f7cd7f6fc98b9bc47f31a11ac1942c62093933d98d36433957389b // Hash value
```

### Download
[Release](https://github.com/AntiquePendulum/HashraTea/releases)  
現在 Windows 64bit Edition のみに対応しています。  
動作環境は Windows 10 で行っています。

## License
Under the MIT

## Develop Requirements 
* .NET Core 3.1

## 権利表記
ConsoleAppFramework Copyright (c) 2020 Cysharp, Inc.  
[LICENSE](https://github.com/Cysharp/ConsoleAppFramework/blob/master/LICENSE)