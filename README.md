# Voxelorer
体験入学などで拡張していくボクセルキャラクターの冒険譚ゲームのリポジトリーです

# 前提
- Unity2017.3.1

# 便利アセット
ステージを作成する時に、ProGridsがインポートされていると便利です。

- <i>Window</i>メニューから<i>Asset Store</i>を選択してアセットストアを開きます
- `ProGrids`を検索
- ダウンロードしてImport
- グリッドを`0.5`か`0.25`にすると、本プロジェクトでは便利です

# 使い方
- 本リポジトリーをクローンするか、ZIPをダウンロードします
- Unityで開きます
- `AM1/Scenes/Stage1`シーンを開くと、テストステージが開きます

## ブロックについて
`AM1/Prefabs`内に以下の通り、ブロックが入っています。これをシーンに配置して、ステージを作成してください。

- Ice Blocks
  - 滑るブロック。まだ処理は未実装なので効果はありません
- Normal Blocks
  - 通常のブロックです
  - 落下せず、動かせません
  - 何種類かのサイズのものを作っています。Scaleでサイズ変更して構いません
- BreakableBlock
  - プレイヤーが下からぶつかったり、勢いよく踏むと壊せるブロックです
  - `Break Particle`を設定すると、壊れる時にパーティクルを発生させます。通常のゲームオブジェクトも生成できます
- Clear Point
  - ステージクリアする場所です
  - ここに到達すると、Inspectorビューの<i>Next Stage Name</i>に設定した名前のシーンに切り替えます
- FuridashiBlock
  - 最後に通過したワープポイントに戻されるブロックです
- MovableBlock
  - プレイヤーが押すことができるブロックです
  - 重力落下します
  - ステージから落ちると、出現場所に再生します
- StartPosition
  - ステージの開始場所です
  - ワープポイントを通過する前は、落下したりFuridashiBlockに接触するとここに戻されます
- Warp Point
  - 設定したワープ先にプレイヤーをワープさせます
  - ワープ先は、Inspectorビューの`Warp Target`で指定します
  - Warp Targetオブジェクトを設定することを想定していますが、Transformを指定すれば他のオブジェクトでも構いません
- Warp Target
  - ワープ先の目印のオブジェクトです

# ライセンス
## Voxelorer関連
- tanakaeduの著作物は、[MITライセンス](./LICENSE.md)で提供します

## SDユニティちゃん
<img src="http://unity-chan.com/images/imageLicenseLogo.png" alt="ユニティちゃんライセンス"><p>本リポジトリーはSDユニティちゃん(Ver1.01)を含んでいます。SDユニティちゃんは、<a href="http://unity-chan.com/contents/license_jp/" target="_blank">ユニティちゃんライセンス条項</a>の元に提供されています</p>

## プレイヤーキャラクターの素体とアーマチュア
- プレイヤーは、[だいしブログ様. MagicaVoxelで作ったプリキュアをUnityで動かす](https://github.dev7.jp/b/2015/12/15/precureadv20151213/)の素体を改変したものです
- Rigは同ブログのアーマチュアデータを利用しました

