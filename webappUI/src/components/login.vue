<template>
    <v-app>
        <v-container class="align-content-lg-center">
            <v-card height="80vh" width="80vw" class="mt-12 align-content-end">
                <v-row>
                    <v-col cols="12" lg="8">
                           </v-col>
                    <v-col cols="12" lg="4">
                        <v-container class="ml-0 mr-4" style="margin-top: 10vh">
                            <v-avatar size="80" style="margin-left: 15vh;">
                            <v-img src="data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSI3NC43NTgiIGhlaWdodD0iNzMuNTk3IiB2aWV3Qm94PSIwIDAgNzQuNzU4IDczLjU5NyI+DQogIDxnIGlkPSJYTUxJRF84NTZfIiB0cmFuc2Zvcm09InRyYW5zbGF0ZSgwIC0yLjYyNSkiPg0KICAgIDxwYXRoIGlkPSJYTUxJRF84NTdfIiBkPSJNMTM3Ljk0MiwyLjYyNWE4Ljg0Miw4Ljg0MiwwLDAsMC04Ljg0Miw4Ljg0MnY4Ljg0MmE4Ljg0Miw4Ljg0MiwwLDEsMCwxNy42ODQsMFYxMS40NjdBOC44NDIsOC44NDIsMCwwLDAsMTM3Ljk0MiwyLjYyNVoiIHRyYW5zZm9ybT0idHJhbnNsYXRlKC0xMDAuNTYzKSIgZmlsbD0iIzQ5NDk0OSIvPg0KICAgIDxnIGlkPSJYTUxJRF84NThfIiB0cmFuc2Zvcm09InRyYW5zbGF0ZSgzNy4zNzkgMi42MjUpIj4NCiAgICAgIDxwYXRoIGlkPSJYTUxJRF84NTlfIiBkPSJNMTc3Ljk0MiwyMC4zMDlhOC44NDIsOC44NDIsMCwwLDEtOC44NDIsOC44NDJoMFYyLjYyNWgwYTguODQyLDguODQyLDAsMCwxLDguODQyLDguODQyWiIgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoLTE2OS4xIC0yLjYyNSkiIGZpbGw9IiM5ZmE5YmMiLz4NCiAgICA8L2c+DQogICAgPGcgaWQ9IlhNTElEXzg2MF8iIHRyYW5zZm9ybT0idHJhbnNsYXRlKDAgMjkuMTUxKSI+DQogICAgICA8cGF0aCBpZD0iWE1MSURfODYxXyIgZD0iTTI0LjEzOCwxMjIuNjI1SDEzLjI2M0ExMy4yNjMsMTMuMjYzLDAsMCwwLDAsMTM1Ljg4OEgyNC4xMzhaIiB0cmFuc2Zvcm09InRyYW5zbGF0ZSgwIC0xMjIuNjI1KSIgZmlsbD0iIzlmYTliYyIvPg0KICAgIDwvZz4NCiAgICA8ZyBpZD0iWE1MSURfODYyXyIgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoMTUuMTkyIDQ5LjA0NSkiPg0KICAgICAgPHBhdGggaWQ9IlhNTElEXzgxXyIgZD0iTTc4LjI3MSwyMTIuNjI1bC02LjcxMyw4LjU1NkExMy4yNjMsMTMuMjYzLDAsMCwwLDczLjgwNiwyMzkuOGwxNC45LTE4Ljk5MVoiIHRyYW5zZm9ybT0idHJhbnNsYXRlKC02OC43MjkgLTIxMi42MjUpIiBmaWxsPSIjNDk0OTQ5Ii8+DQogICAgPC9nPg0KICAgIDxnIGlkPSJYTUxJRF84NjNfIiB0cmFuc2Zvcm09InRyYW5zbGF0ZSgzOS41ODkgNDkuMDQ1KSI+DQogICAgICA8cGF0aCBpZD0iWE1MSURfNzlfIiBkPSJNMTg5LjUzNCwyMTIuNjI1bDYuNzEzLDguNTU2QTEzLjI2MywxMy4yNjMsMCwwLDEsMTk0LDIzOS44bC0xNC45LTE4Ljk5MVoiIHRyYW5zZm9ybT0idHJhbnNsYXRlKC0xNzkuMSAtMjEyLjYyNSkiIGZpbGw9IiM0OTQ5NDkiLz4NCiAgICA8L2c+DQogICAgPGcgaWQ9IlhNTElEXzg2NF8iIHRyYW5zZm9ybT0idHJhbnNsYXRlKDUwLjYyIDI5LjE1MSkiPg0KICAgICAgPHBhdGggaWQ9IlhNTElEXzg2NV8iIGQ9Ik0yMjksMTIyLjYyNWgxMC44NzVhMTMuMjYzLDEzLjI2MywwLDAsMSwxMy4yNjMsMTMuMjYzSDIyOVoiIHRyYW5zZm9ybT0idHJhbnNsYXRlKC0yMjkgLTEyMi42MjUpIiBmaWxsPSIjOWZhOWJjIi8+DQogICAgPC9nPg0KICAgIDxnIGlkPSJYTUxJRF84NjZfIiB0cmFuc2Zvcm09InRyYW5zbGF0ZSgyMS43OTUgMTUuODg3KSI+DQogICAgICA8cGF0aCBpZD0iWE1MSURfODY3XyIgZD0iTTExNC4xOTIsODkuMTQ5LDEyOS43ODQsNjcuNjlhMjYuNTI2LDI2LjUyNiwwLDAsMC0zMS4xODUsMFoiIHRyYW5zZm9ybT0idHJhbnNsYXRlKC05OC41OTkgLTYyLjYyMykiIGZpbGw9IiMwOWEwMTUiLz4NCiAgICA8L2c+DQogICAgPGcgaWQ9IlhNTElEXzg2OF8iIHRyYW5zZm9ybT0idHJhbnNsYXRlKDM3LjM4OCAxNS44ODcpIj4NCiAgICAgIDxwYXRoIGlkPSJYTUxJRF84NjlfIiBkPSJNMTY5LjEzOSw4OS4xNDksMTg0LjczMiw2Ny42OWEyNi40MDYsMjYuNDA2LDAsMCwwLTE1LjU5My01LjA2N1oiIHRyYW5zZm9ybT0idHJhbnNsYXRlKC0xNjkuMTM5IC02Mi42MjMpIiBmaWxsPSIjMDljNTE3Ii8+DQogICAgPC9nPg0KICAgIDxnIGlkPSJYTUxJRF84NzBfIiB0cmFuc2Zvcm09InRyYW5zbGF0ZSgxMC44NTUgMjAuOTUzKSI+DQogICAgICA8cGF0aCBpZD0iWE1MSURfNzBfIiBkPSJNNzUuNjQsMTA3LDYwLjA0OSw4NS41MzhBMjYuNTI2LDI2LjUyNiwwLDAsMCw1MC40MTMsMTE1LjJaIiB0cmFuc2Zvcm09InRyYW5zbGF0ZSgtNDkuMTA4IC04NS41MzgpIiBmaWxsPSIjMDljNTE3Ii8+DQogICAgPC9nPg0KICAgIDxwYXRoIGlkPSJYTUxJRF84NzFfIiBkPSJNODAuMjM4LDE4Mi42MzF2LS4wMDZsLS4wMDksMC0uMDA5LDB2LjAwNmwtMjUuMjExLDguMTlhMjYuNTI1LDI2LjUyNSwwLDAsMCwyNS4yMDksMTguMzNoLjAyYTI2LjUyNSwyNi41MjUsMCwwLDAsMjUuMjA5LTE4LjMzWiIgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoLTQyLjg1IC0xNDAuMjEyKSIgZmlsbD0iIzA5YTAxNSIvPg0KICAgIDxnIGlkPSJYTUxJRF84NzJfIiB0cmFuc2Zvcm09InRyYW5zbGF0ZSgzNy4zODYgNDIuNDEzKSI+DQogICAgICA8cGF0aCBpZD0iWE1MSURfNjdfIiBkPSJNMTY5LjEzNCwxODIuNjI1djI2LjUyNmEyNi41MjcsMjYuNTI3LDAsMCwwLDI1LjIzLTE4LjMzWiIgdHJhbnNmb3JtPSJ0cmFuc2xhdGUoLTE2OS4xMzMgLTE4Mi42MjUpIiBmaWxsPSIjMDljNTE3Ii8+DQogICAgPC9nPg0KICAgIDxnIGlkPSJYTUxJRF84NzNfIiB0cmFuc2Zvcm09InRyYW5zbGF0ZSgzNy4zODggMjAuOTUyKSI+DQogICAgICA8cGF0aCBpZD0iWE1MSURfNjVfIiBkPSJNMTY5LjEzOSwxMDdsMjUuMjI3LDguMmEyNi41MjgsMjYuNTI4LDAsMCwwLTkuNjM3LTI5LjY1OVoiIHRyYW5zZm9ybT0idHJhbnNsYXRlKC0xNjkuMTM5IC04NS41MzcpIiBmaWxsPSIjMDlhMDE1Ii8+DQogICAgPC9nPg0KICAgIDxnIGlkPSJYTUxJRF84NzdfIiB0cmFuc2Zvcm09InRyYW5zbGF0ZSgyMy43MjIgMzAuNzk0KSI+DQogICAgICA8cGF0aCBpZD0iWE1MSURfNjBfIiBkPSJNMTI5LjQzLDEzMC4wNmw1LjIxOSwxNi4wNjQtMTMuNjY1LDkuOTI4LTEzLjY2NS05LjkyOCw1LjIyLTE2LjA2NFoiIHRyYW5zZm9ybT0idHJhbnNsYXRlKC0xMDcuMzE5IC0xMzAuMDYpIiBmaWxsPSIjMDI5MDBkIi8+DQogICAgPC9nPg0KICAgIDxnIGlkPSJYTUxJRF84NzhfIiB0cmFuc2Zvcm09InRyYW5zbGF0ZSgzNy4zNzkgMzAuNzk0KSI+DQogICAgICA8cGF0aCBpZD0iWE1MSURfNThfIiBkPSJNMTc3LjU1NCwxMzAuMDZsNS4yMTksMTYuMDY0LTEzLjY2NSw5LjkyOEwxNjkuMSwxMzAuMDZaIiB0cmFuc2Zvcm09InRyYW5zbGF0ZSgtMTY5LjEgLTEzMC4wNikiIGZpbGw9IiMwMGQwMTAiLz4NCiAgICA8L2c+DQogIDwvZz4NCjwvc3ZnPg0K"></v-img>
                            </v-avatar>
                                <v-container class="align-content-center text-center font-weight-black font-weight-bold" style="margin-bottom: 5vh; font-size: x-large;">
                                <v-card flat>
                                    Be One Of Us!
                                </v-card>
                            </v-container>
                            <v-form ref="form"
                                    v-model="valid"
                                    lazy-validation>
                            <v-text-field
                                    label="Username"
                                    placeholder="username"
                                    :rules="[rules.required]"
                                    v-model="username"
                                    outlined
                                    hint="Required"
                                    color="#7cfc00"
                                    class="mr-6"
                            ></v-text-field>
                            <v-text-field
                                    :append-icon="show2 ? 'mdi-eye' : 'mdi-eye-off'"
                                    :rules="[rules.required, rules.min]"
                                    :type="show2 ? 'text' : 'password'"
                                    placeholder="password"
                                    name="input-10-2"
                                    label="Password"
                                    hint="Required"
                                    outlined=""
                                    class="input-group--focused mr-6"
                                    color="#7cfc00"
                                    @click:append="show2 = !show2"
                            ></v-text-field>
                        <v-btn color="green" width="20vw" height="8vh" class="white--text" @click="validate()">Login</v-btn>
                                <v-card flat v-if="alert" class="red--text">{{errormessage}}</v-card>
                            </v-form>

                            <v-spacer></v-spacer>
                            <v-card flat> If you do not have an account <span class="light-green--text">Sign Up</span></v-card>
                        </v-container>
                    </v-col>
                </v-row>

            </v-card>
            <v-card flat height="85vh" width="50vw" style="margin-top: -90vh; margin-left: -5vw;">
                <v-img height="85vh" src="https://images.unsplash.com/photo-1546970022-5fe45da22264?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1000&q=80" ></v-img>
            </v-card>


        </v-container>

    </v-app>

</template>

<script>
    import axios from 'axios';

    export default {
        name: "login",
        data (){
            return {
                show1: false,
                show2: true,
                show3: false,
                show4: false,
                valid: false,
                username: null,
                alert: false,
                errormessage: '',
                password: 'Password',
                rules: {
                    required: value => !!value || 'Required.',
                    min: v => v.length >= 8 || 'Min 8 characters',
                    emailMatch: () => ('The email and password you entered don\'t match'),
                },
            }
        },
        methods: {
            authenticate () {
                this.alert = false;
                const payload = {
                    username: this.username,
                    password: this.password
                };
                console.log(this.$http.post('accounts/login/', payload));
                this.$http.post('accounts/login/', payload)
                    .then((response) => {
                        this.$store.commit('updateToken', response.data.token);
                        if(response.data.token){
                            this.$store.commit("setAuthUser",
                                {authUser: response.data, isAuthenticated: true}
                            );
                            this.isAuthen = true;
                            console.log(this.isAuthen);
                            this.$router.push('/home');
                        }
                        console.log(response.data);
                        const base = {
                            baseURL: this.$store.state.endpoints.baseURL,
                            headers: {
                                // Set your Authorization to 'JWT', not Bearer!!!
                                Authorization: `JWT ${this.$store.state.jwt}`,
                                'Content-Type': 'application/json'
                            },
                            xhrFields: {
                                withCredentials: true
                            }
                        }
                        // Even though the authentication returned a user object that can be
                        // decoded, we fetch it again. This way we aren't super dependant on
                        // JWT and can plug in something else.
                        const axiosInstance = axios.create(base)
                        axiosInstance({
                            url: "users/",
                            method: "get",
                            params: {}
                        })
                            .then((response) => {
                                this.$store.commit("setAuthUser",
                                    {authUser: response.data, isAuthenticated: true}
                                );
                                this.isAuthen = this.$store.state.isAuthenticated;
                            })

                    })
                    .catch((error) => {
                        console.log(error);
                        console.debug(error);
                        console.dir(error);
                        this.alert = true;
                        this.errormessage = 'Wrong password or Username';
                        this.$router.push('/login');

                    })
            },
            signout(){
                this.$store.commit("setAuthUser",
                    {authUser: null, isAuthenticated: false}
                );
                this.isAuthen = this.$store.state.isAuthenticated;
                this.$router.push('/');
            },

            events () {
                this.$http.get('unknown/')
                    .then((response) => {
                        console.log(response.data);
                        this.recentevents = response.data.data;
                        console.log(this.recentevents);
                    })

            },
            isauthenticat() {
                console.log(this.$store.state.isAuthenticated);
                this.isAuthen = this.$store.state.isAuthenticated;
                console.log(this.isAuthen);
            },
            validate () {
                if (this.$refs.form.validate()) {
                    this.authenticate();
                    this.snackbar = true;
                }
            },
        },
    }
</script>

<style scoped>

</style>