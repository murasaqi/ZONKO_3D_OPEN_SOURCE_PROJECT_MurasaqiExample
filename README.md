# ZONKO_3D_OPEN_SOURCE_PROJECT

## 概要

本プロジェクトはZONKO_3D_OPEN_SOURCE_PROJECTにおける活用事例の一つです。  
※本プロジェクトに含まれるぞん子3Dモデル（「ZONKO 3D MODEL type-N」）の利用規約を必ずご確認の上、使用してください。  
利用規約：https://zone-energy.jp/3dmodel/terms.pdf  
  
プロジェクト概要については    
[こちら(https://zonko.zone-energy.jp/3dmodel)](https://zonko.zone-energy.jp/3dmodel)  
をご覧ください。

## 推奨環境
Unity 2021.3.14f1以上 (2021最新LTS推奨)  
GPU RTX 2060ti 以上  
CPU Ryzen5 5600X 以上  
初期状態では一部の設定が軽めに設定されています。


## セットアップ

### Gitのインストール
ご利用のPCにGitがインストールされてない方はダウンロードをしてインストールしてください。  

[Windows](https://gitforwindows.org/)  
[Mac](https://git-scm.com/download/mac)  

## プロジェクトのダウンロード
Releaseの最新版からダウンロードしてください。  
GitHubを普段からご利用の方はCloneしてもらっても大丈夫です。


## 外部パッケージ
プロジェクトにエラーが出た場合は、依存しているパッケージを個別にインストールすることで解決することがあります。  
必要なパッケージのインストール方法をそれぞれ解説します。  

#### UniVRMのインポート
[UniVRM](https://github.com/vrm-c/UniVRM/releases/tag/v0.107.0)  
for vrm-0.x UniVRM-0.107.0_1e8a.unitypackage の方をインポートしてください。

#### lilToonのインポート
[lilToon](https://github.com/lilxyzw/lilToon/releases/tag/1.3.6)
1.3.6のunitypackageをインポートしてください

#### uLipSyncのインポート
[uLipSync](https://github.com/hecomi/uLipSync/releases/tag/v2.4.0)
v2.4.0のunitypackageをインポートしてください。


## 注意点
### プロジェクト内容
本プロジェクトは配布されている「ZONKO 3D MODEL type-N」のみで再編されたプロジェクトになります。  
(※デモムービーにあった別バージョンのモデルは含まれておりません)

### プロジェクト設定
本プロジェクトを完成映像と同じ状態にするためには一部設定を変更する必要があります。  

Environments > Sky and Fog Global Volume  
のVolumeFog設定を以下のよう変更してください。
![Doc 00](./doc_00.png)

Environments > Global Volume  
のScreen Space Global IlluminationのQualityをHighにしてください。
![Doc 02](./doc_02.png)

カメラにアタッチされているRenderTextureの解像度を4Kに変更してください。
![Doc 01](./doc_01.png)

レンダリング時の設定であり、Playする場合は非常にEditorが重くなりますので気をつけください。

## 開発に利用したパッケージ
本開発に使っていたパッケージ一覧です。  
制作の参考にしてください。  

[liltoon](https://booth.pm/ja/items/3087170)  
[QHierarchy](https://assetstore.unity.com/packages/tools/utilities/qhierarchy-28577)  
[Rainbow Folders 2](https://assetstore.unity.com/packages/tools/utilities/rainbow-folders-2-143526)  
[uLipSync](https://github.com/hecomi/uLipSync)  
[VRM](https://vrm.dev/univrm/install/univrm_upm.html)  
