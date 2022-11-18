

function TopComponent() {
    return (
        <div>
            <img src="./img/M2ILOGO2.png" alt="logo m2i" />
            <h2>M2I formation</h2>
            <span>Une formation sur mesure</span>
        </div>
    )
}
function LeftComponent() {
    return (
        <div>left</div>
    )
}
function CenterComponent() {
    return (
        <div>center</div>
    )
}
function RightComponent() {
    return (
        <div>right</div>
    )
}
function BottomComponent() {
    return (
        <div>Ma premiere page perso générée par réact @Copyright-2022 <a href="https://fr-fr.facebook.com/" target="_blanck">Me contacter</a></div>
    )
}


function MyPage() {
    return (
        <div class="row">
            <div class="componentClass1 col col-12"><TopComponent /></div>
            <div class="componentClass2 col col-2"><LeftComponent /></div>
            <div class="componentClass3 col col-8"><CenterComponent /></div>
            <div class="componentClass4 col col-2"><RightComponent /></div>
            <div class="componentClass5 col col-12"><BottomComponent /></div>
        </div>
    )
}
ReactDOM.render(
    <React.StrictMode>
        <MyPage />
    </React.StrictMode>,
    document.getElementById('app')
);
