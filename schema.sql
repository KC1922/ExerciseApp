PGDMP      (                |           ExerciseProject    16.2    16.2 3    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16517    ExerciseProject    DATABASE     �   CREATE DATABASE "ExerciseProject" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United States.1252';
 !   DROP DATABASE "ExerciseProject";
                postgres    false            �            1259    16638 	   exercises    TABLE     �   CREATE TABLE public.exercises (
    exerid integer NOT NULL,
    exercise_name character varying(50) NOT NULL,
    exercise_type character varying(50) NOT NULL
);
    DROP TABLE public.exercises;
       public         heap    postgres    false            �            1259    16637    Exercises_exerid_seq    SEQUENCE     �   CREATE SEQUENCE public."Exercises_exerid_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public."Exercises_exerid_seq";
       public          postgres    false    222            �           0    0    Exercises_exerid_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public."Exercises_exerid_seq" OWNED BY public.exercises.exerid;
          public          postgres    false    221            �            1259    16663    timing    TABLE     �   CREATE TABLE public.timing (
    workout_id integer NOT NULL,
    date timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    start_time timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    duration interval
);
    DROP TABLE public.timing;
       public         heap    postgres    false            �            1259    16662    Timing_workoutId_seq    SEQUENCE     �   CREATE SEQUENCE public."Timing_workoutId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public."Timing_workoutId_seq";
       public          postgres    false    226            �           0    0    Timing_workoutId_seq    SEQUENCE OWNED BY     P   ALTER SEQUENCE public."Timing_workoutId_seq" OWNED BY public.timing.workout_id;
          public          postgres    false    225            �            1259    16612    user_physical_details    TABLE     �   CREATE TABLE public.user_physical_details (
    user_id integer NOT NULL,
    age integer,
    height numeric(8,2) DEFAULT 5.5,
    gender character varying(10)
);
 )   DROP TABLE public.user_physical_details;
       public         heap    postgres    false            �            1259    16611    UserPhysicalDetails_userId_seq    SEQUENCE     �   CREATE SEQUENCE public."UserPhysicalDetails_userId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 7   DROP SEQUENCE public."UserPhysicalDetails_userId_seq";
       public          postgres    false    218            �           0    0    UserPhysicalDetails_userId_seq    SEQUENCE OWNED BY     f   ALTER SEQUENCE public."UserPhysicalDetails_userId_seq" OWNED BY public.user_physical_details.user_id;
          public          postgres    false    217            �            1259    16605    users    TABLE       CREATE TABLE public.users (
    user_id integer NOT NULL,
    email character varying(50) NOT NULL,
    username character varying(25) NOT NULL,
    password character varying(50) NOT NULL,
    fname character varying(50),
    lname character varying(50)
);
    DROP TABLE public.users;
       public         heap    postgres    false            �            1259    16604    Users_userid_seq    SEQUENCE     �   CREATE SEQUENCE public."Users_userid_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public."Users_userid_seq";
       public          postgres    false    216            �           0    0    Users_userid_seq    SEQUENCE OWNED BY     H   ALTER SEQUENCE public."Users_userid_seq" OWNED BY public.users.user_id;
          public          postgres    false    215            �            1259    16625    weight    TABLE     �   CREATE TABLE public.weight (
    weight_id integer NOT NULL,
    user_id integer NOT NULL,
    weight numeric(8,2) NOT NULL,
    date timestamp without time zone DEFAULT CURRENT_TIMESTAMP NOT NULL
);
    DROP TABLE public.weight;
       public         heap    postgres    false            �            1259    16624    Weight_weightId_seq    SEQUENCE     �   CREATE SEQUENCE public."Weight_weightId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public."Weight_weightId_seq";
       public          postgres    false    220            �           0    0    Weight_weightId_seq    SEQUENCE OWNED BY     N   ALTER SEQUENCE public."Weight_weightId_seq" OWNED BY public.weight.weight_id;
          public          postgres    false    219            �            1259    16645    workouts    TABLE     �   CREATE TABLE public.workouts (
    workout_id integer NOT NULL,
    user_id integer NOT NULL,
    exercise integer NOT NULL,
    calories_burned integer DEFAULT 0,
    max_hr integer,
    min_hr integer
);
    DROP TABLE public.workouts;
       public         heap    postgres    false            �            1259    16644    Workouts_workoutId_seq    SEQUENCE     �   CREATE SEQUENCE public."Workouts_workoutId_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public."Workouts_workoutId_seq";
       public          postgres    false    224            �           0    0    Workouts_workoutId_seq    SEQUENCE OWNED BY     T   ALTER SEQUENCE public."Workouts_workoutId_seq" OWNED BY public.workouts.workout_id;
          public          postgres    false    223            8           2604    16641    exercises exerid    DEFAULT     v   ALTER TABLE ONLY public.exercises ALTER COLUMN exerid SET DEFAULT nextval('public."Exercises_exerid_seq"'::regclass);
 ?   ALTER TABLE public.exercises ALTER COLUMN exerid DROP DEFAULT;
       public          postgres    false    221    222    222            ;           2604    16666    timing workout_id    DEFAULT     w   ALTER TABLE ONLY public.timing ALTER COLUMN workout_id SET DEFAULT nextval('public."Timing_workoutId_seq"'::regclass);
 @   ALTER TABLE public.timing ALTER COLUMN workout_id DROP DEFAULT;
       public          postgres    false    225    226    226            4           2604    16615    user_physical_details user_id    DEFAULT     �   ALTER TABLE ONLY public.user_physical_details ALTER COLUMN user_id SET DEFAULT nextval('public."UserPhysicalDetails_userId_seq"'::regclass);
 L   ALTER TABLE public.user_physical_details ALTER COLUMN user_id DROP DEFAULT;
       public          postgres    false    218    217    218            3           2604    16608    users user_id    DEFAULT     o   ALTER TABLE ONLY public.users ALTER COLUMN user_id SET DEFAULT nextval('public."Users_userid_seq"'::regclass);
 <   ALTER TABLE public.users ALTER COLUMN user_id DROP DEFAULT;
       public          postgres    false    216    215    216            6           2604    16628    weight weight_id    DEFAULT     u   ALTER TABLE ONLY public.weight ALTER COLUMN weight_id SET DEFAULT nextval('public."Weight_weightId_seq"'::regclass);
 ?   ALTER TABLE public.weight ALTER COLUMN weight_id DROP DEFAULT;
       public          postgres    false    220    219    220            9           2604    16648    workouts workout_id    DEFAULT     {   ALTER TABLE ONLY public.workouts ALTER COLUMN workout_id SET DEFAULT nextval('public."Workouts_workoutId_seq"'::regclass);
 B   ALTER TABLE public.workouts ALTER COLUMN workout_id DROP DEFAULT;
       public          postgres    false    223    224    224            �          0    16638 	   exercises 
   TABLE DATA           I   COPY public.exercises (exerid, exercise_name, exercise_type) FROM stdin;
    public          postgres    false    222   �;       �          0    16663    timing 
   TABLE DATA           H   COPY public.timing (workout_id, date, start_time, duration) FROM stdin;
    public          postgres    false    226   �;       �          0    16612    user_physical_details 
   TABLE DATA           M   COPY public.user_physical_details (user_id, age, height, gender) FROM stdin;
    public          postgres    false    218   ,<       �          0    16605    users 
   TABLE DATA           Q   COPY public.users (user_id, email, username, password, fname, lname) FROM stdin;
    public          postgres    false    216   v<       �          0    16625    weight 
   TABLE DATA           B   COPY public.weight (weight_id, user_id, weight, date) FROM stdin;
    public          postgres    false    220   v=       �          0    16645    workouts 
   TABLE DATA           b   COPY public.workouts (workout_id, user_id, exercise, calories_burned, max_hr, min_hr) FROM stdin;
    public          postgres    false    224   �=       �           0    0    Exercises_exerid_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public."Exercises_exerid_seq"', 2, true);
          public          postgres    false    221            �           0    0    Timing_workoutId_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."Timing_workoutId_seq"', 1, false);
          public          postgres    false    225            �           0    0    UserPhysicalDetails_userId_seq    SEQUENCE SET     O   SELECT pg_catalog.setval('public."UserPhysicalDetails_userId_seq"', 1, false);
          public          postgres    false    217            �           0    0    Users_userid_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public."Users_userid_seq"', 14, true);
          public          postgres    false    215            �           0    0    Weight_weightId_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public."Weight_weightId_seq"', 3, true);
          public          postgres    false    219            �           0    0    Workouts_workoutId_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public."Workouts_workoutId_seq"', 2, true);
          public          postgres    false    223            E           2606    16643    exercises Exercises_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.exercises
    ADD CONSTRAINT "Exercises_pkey" PRIMARY KEY (exerid);
 D   ALTER TABLE ONLY public.exercises DROP CONSTRAINT "Exercises_pkey";
       public            postgres    false    222            I           2606    16670    timing Timing_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.timing
    ADD CONSTRAINT "Timing_pkey" PRIMARY KEY (workout_id);
 >   ALTER TABLE ONLY public.timing DROP CONSTRAINT "Timing_pkey";
       public            postgres    false    226            A           2606    16618 .   user_physical_details UserPhysicalDetails_pkey 
   CONSTRAINT     s   ALTER TABLE ONLY public.user_physical_details
    ADD CONSTRAINT "UserPhysicalDetails_pkey" PRIMARY KEY (user_id);
 Z   ALTER TABLE ONLY public.user_physical_details DROP CONSTRAINT "UserPhysicalDetails_pkey";
       public            postgres    false    218            ?           2606    16610    users Users_pkey 
   CONSTRAINT     U   ALTER TABLE ONLY public.users
    ADD CONSTRAINT "Users_pkey" PRIMARY KEY (user_id);
 <   ALTER TABLE ONLY public.users DROP CONSTRAINT "Users_pkey";
       public            postgres    false    216            C           2606    16631    weight Weight_pkey 
   CONSTRAINT     Y   ALTER TABLE ONLY public.weight
    ADD CONSTRAINT "Weight_pkey" PRIMARY KEY (weight_id);
 >   ALTER TABLE ONLY public.weight DROP CONSTRAINT "Weight_pkey";
       public            postgres    false    220            G           2606    16651    workouts Workouts_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.workouts
    ADD CONSTRAINT "Workouts_pkey" PRIMARY KEY (workout_id);
 B   ALTER TABLE ONLY public.workouts DROP CONSTRAINT "Workouts_pkey";
       public            postgres    false    224            N           2606    16671    timing Timing_workoutId_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.timing
    ADD CONSTRAINT "Timing_workoutId_fkey" FOREIGN KEY (workout_id) REFERENCES public.workouts(workout_id);
 H   ALTER TABLE ONLY public.timing DROP CONSTRAINT "Timing_workoutId_fkey";
       public          postgres    false    224    226    4679            J           2606    16619 5   user_physical_details UserPhysicalDetails_userId_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.user_physical_details
    ADD CONSTRAINT "UserPhysicalDetails_userId_fkey" FOREIGN KEY (user_id) REFERENCES public.users(user_id);
 a   ALTER TABLE ONLY public.user_physical_details DROP CONSTRAINT "UserPhysicalDetails_userId_fkey";
       public          postgres    false    216    4671    218            K           2606    16632    weight Weight_userId_fkey    FK CONSTRAINT        ALTER TABLE ONLY public.weight
    ADD CONSTRAINT "Weight_userId_fkey" FOREIGN KEY (user_id) REFERENCES public.users(user_id);
 E   ALTER TABLE ONLY public.weight DROP CONSTRAINT "Weight_userId_fkey";
       public          postgres    false    216    4671    220            L           2606    16657    workouts Workouts_exercise_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.workouts
    ADD CONSTRAINT "Workouts_exercise_fkey" FOREIGN KEY (exercise) REFERENCES public.exercises(exerid);
 K   ALTER TABLE ONLY public.workouts DROP CONSTRAINT "Workouts_exercise_fkey";
       public          postgres    false    222    4677    224            M           2606    16652    workouts Workouts_userId_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.workouts
    ADD CONSTRAINT "Workouts_userId_fkey" FOREIGN KEY (user_id) REFERENCES public.users(user_id);
 I   ALTER TABLE ONLY public.workouts DROP CONSTRAINT "Workouts_userId_fkey";
       public          postgres    false    224    4671    216            �   5   x�3�*����K�tN,J���2�O�L�(��L+	��楗dp��qqq wL      �   <   x�3�4202�50�54U00�#d1Cs������������!D��:�LLA:c���� Bh�      �   :   x�3�46�447�35��M�I�2�42�443�30�tK�	�p��q����q��qqq 2�
�      �   �   x��бj�0���[�BOv�z%��fݲ���V*��кO_96�P(	H~}w:D8�h�ߦi�>���&�/�JB.��VX�˕���k��3���k��$��c݅���W�ǘ�r+��z��]z}�~Ba�(�֋��1+�@Yqx�K=_a�?|�f��g9��t2z�ĻA�R�5�<�xvl��vp�c/�)���u��3r�Ρ�lc��E�w/����R��8�RJ��e�      �   J   x�}ʱ�0�ڞ�b�?�<��-�I�������#w-x!�4�b�7M˲��O�l]�'�$����`�      �   '   x�3�4BcNC3 62�2�C��)p��qqq x��     