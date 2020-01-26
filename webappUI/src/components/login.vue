<template>
    <v-app>
        <v-container class="align-content-lg-center">
            <v-card height="80vh" width="80vw" class="mt-12 align-content-end">
                <v-row>
                    <v-col cols="12" lg="8">
                    </v-col>
                    <v-col cols="12" lg="4">

                        <v-container class="ml-0 mr-4" style="margin-top: 20vh">
                            <v-container class="align-content-center text-center font-weight-black font-weight-bold" style="margin-bottom: 5vh; font-size: x-large;">
                                <v-card flat>
                                    Be One Of Us!
                                </v-card>
                            </v-container>

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
                        <v-btn color="green" width="20vw" height="8vh" class="white--text" @click="authenticate">Login</v-btn>
                            <v-card flat v-if="alert" class="red--text">{{errormessage}}</v-card>
                            <v-card> If you do not have and account <span class="light-green--text">Sign Up</span></v-card>
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
                    email: this.username,
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
                            this.$router.push('/');
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
        },
    }
</script>

<style scoped>

</style>