# ZONKO_3D_OPEN_SOURCE_PROJECT

## 概要
本プロジェクトはZONKO_3D_OPEN_SOURCE_PROJECTにおける活用事例の一つです。
詳しくはこちらをご覧ください。

## 推奨環境
GPU RTX3080以上  
CPU Ryzen 5959X相当  
初期状態では一部の設定が軽めに設定されています。


## セットアップ

### Gitのインストール
ご利用のPCにGitがインストールされてない方はダウンロードをしてインストールしてください。  

[Windows](https://gitforwindows.org/)  
[Mac](https://git-scm.com/download/mac)  

## プロジェクトのダウンロード
Releaseの最新版からダウンロードしてください。  
GitHubを普段からご利用の方はCloneしてもらっても大丈夫です。


## 注意点
### プロジェクト内容
本プロジェクトは配布されている「ZONKO 3D MODEL type-N」のみで再編されたプロジェクトになります。  
(※デモムービーにあった別バージョンのモデルは含まれておりません)

### プロジェクト設定
本プロジェクトを完成映像と同じ状態にするためには一部設定を変更する必要があります。  

Environments > Sky and Fog Global Volume  
のVolumeFog設定を以下のよう変更してください。
![Doc 00](./doc_00.png)

カメラにアタッチされているRenderTextureの解像度を4Kに変更してください。
![Doc 00](./doc_01.png)

レンダリング時の設定であり、Playする場合は非常にEditorが重くなりますので気をつけください。

## 開発に利用したパッケージ
本開発に使っていたパッケージ一覧です。  
制作の参考にしてください。  

[liltoon](https://booth.pm/ja/items/3087170)  
[QHierarchy](https://assetstore.unity.com/packages/tools/utilities/qhierarchy-28577)  
[Rainbow Folders 2](https://assetstore.unity.com/packages/tools/utilities/rainbow-folders-2-143526)  
[uLipSync](https://github.com/hecomi/uLipSync)  
[VRM](https://vrm.dev/univrm/install/univrm_upm.html)  