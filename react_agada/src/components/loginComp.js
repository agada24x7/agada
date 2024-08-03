
export default function LoginComp(){

    return(

        <div>
            <h1>Login Page</h1>
            <form action="" method="post">
                Uid:
                <input type="text" name="uid"/>
                Password:
                <input type="password" name="password" />
                <input type="submit" value="login" />
            </form>
        </div>
    );
}