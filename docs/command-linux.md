# Linux コマンド

| 改版履歴 | 作成日    | 作成・編集者 | 備考 |
| :------- | :-------- | :----------- | :--- |
| 初版     | 2022/1/19 | 古川 貴一    | /    |

Linux コマンドとは，Linux 系列の OS（Ubuntu，CentOS など）においてコマンドライン（ターミナルなどの黒い画面）から命令を与えるコマンドのことです．  
Windows は windows OS なので関係ないと思うかもしれませんが，windwos で git を扱うための「git bash」は Windows の Linux ツールなため，命令は Linux コマンドを使用します．そのため，本資料で示すコマンド等を実行するのは「git bash」を起動してコマンドを実行してください．  
また，言葉の意味を理解してほしいものがあるためそれらを以下に示します．

| 言葉                 | 意味                                                                                                      |
| :------------------- | :-------------------------------------------------------------------------------------------------------- |
| パス                 | ファイルやフォルダ（ディレクトリ）がコンピューター上のどこにあるかを示す住所のこと．「/」で区切って表す． |
| 絶対パス             | ルートディレクトリと呼ばれる階層構造の頂点から目的地までの経路を表す．                                    |
| 相対パス             | ユーザが現在作業しているフォルダから目的のフォルダまでの経路を表す．                                      |
| ディレクトリ         | ファイルを分類・管理するための概念であり，ファイルを格納する入れ物のこと． Windows では、フォルダのこと． |
| ルートディレクトリ   | 階層型ファイル構造における最上階層のディレクトリ（あるいはフォルダ）のことである．                        |
| カレントディレクトリ | 現在いるディレクトリ，作業しているディレクトリのこと．pwd で表示されるパスの場所のこと．                  |

## 主に使用する Linux コマンド

以下では，主に使用するそれぞれのコマンドとその使い方を示します．

| コマンド名 | 命令内容                               | 由来                    |
| :--------- | :------------------------------------- | :---------------------- |
| pwd        | 今いるディレクトリの絶対パスを表示     | print working directory |
| ls         | ファイルやディレクトリを表示           | list                    |
| cd         | 階層移動（カレントディレクトリの変更） | change directory        |
| mkdir      | ディレクトリの作成                     | make directory          |
| rm         | ファイル（やディレクトリ）の削除       | remove                 |

### pwd コマンド

```
# カレントディレクトリを絶対パスで表示
$ pwd
/Users/furukawakiichi/unity/cubelockey
```

### ls コマンド

```
# カレントディレクトリを表示
$ ls
Assets          Packages        ProjectSettings README.md       docs

# パスを指定してカレントディレクトリを表示（.は現在の位置を示す）
$ ls ./
Assets          Packages        ProjectSettings README.md       docs

# パスを指定してルートディレクトリを表示（/は最上階層（ルートディレクトリ）の位置を示す）
$ ls /
Applications Library System Users Volumes bin cores dev etc home opt private sbin tmp usr var
```

### cd コマンド

```
$ pwd
/Users/furukawakiichi/unity/cubelockey

# カレントディレクトリをAssetsに変更
$ cd Assets

$ pwd
/Users/furukawakiichi/unity/cubelockey/Assets

```

### mkdir コマンド

```
$ ls
Assets          Packages        ProjectSettings README.md       docs

# カレントディレクトリに新しく「test1」ディレクトリを作成
$ mkdir test1

$ ls
Assets          Packages        ProjectSettings README.md       docs            test1
```

### rm コマンド

rm コマンドでは，削除したファイルやディレクトリをもとに戻すことができないので注意しましょう（windows のゴミ箱のような概念はないと思ってください）．

```
$ ls
Assets          Packages        ProjectSettings README.md       docs            test1

# rmコマンドで「test1」ディレクトリを削除しようとする（失敗します）
$ rm test1
rm: test1: is a directory ← test1はディレクトリだから削除できないと言われています

# 「-r」オプションをつけてディレクトリを再帰的に削除するようにする．
$ rm -r test1

$ ls
Assets          Packages        ProjectSettings README.md       docs
```
